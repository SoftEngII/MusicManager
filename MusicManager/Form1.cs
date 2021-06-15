using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using System.Windows;


namespace MusicManager
{
    //private FileSelect
    public partial class FormMain : Form
    {
        
        private List<List<AudioFile>> AudioBookSets = new List<List<AudioFile>>();
        RemoveText RemoveSelected;
        // VLC media player
        private LibVLC _libVLC;
        private MediaPlayer _mp;
        private string _currentSongPlayingPath;
        private int currentsongIndex;
        private int trackID = 0;

        List<AudioFile> songStorage = new List<AudioFile>(); // this shouldn't be needed anymore, left in because I may be wrong

        public FormMain()
        {
            
            InitializeComponent();
            // VLC Media Player
            LibVLCSharp.Shared.Core.Initialize();
            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);

            // setting the filter, | goes between definition and between different sorts
            this.openFileDialog.Filter = "mp3s |*.mp3;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<int> allRows = FindSelectedSongs();

            if (allRows.Count != 0)
            {
                this.saveFileDialog.DefaultExt = @"";
                DialogResult dr = this.saveFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string saveLocation = this.saveFileDialog.FileName;


                    // Creates folder
                    System.IO.Directory.CreateDirectory(saveLocation);

                    // pull data from dataGridViewFileList to compare to songStorage, since they may not be synchronized 
                    List<string> filePaths = new List<string>();
                    foreach (int row in allRows)
                    {
                        string FilePath = (string)dataGridViewFileList.Rows[row].Cells["FilePathColumn"].Value;
                        filePaths.Add(FilePath);

                    }

                    // Write the song path into the text file on it's own line
                    foreach (string filepath in filePaths)
                    {
                        //I didn't wanna make a temp AudioFile just to access this function.
                        string Name = filepath;
                        Name = Name.Substring(0, Name.LastIndexOf(@"."));
                        Name = Name.Remove(0, Name.LastIndexOf(@"\") + 1);

                        string copyLocation = saveLocation + @"\" + Name + @".mp3";
                        File.Copy(filepath, copyLocation);
                    }



                }
            }




        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if(songStorage.Count == 0)
            { return; }
            string playPath = songStorage[FindSelectedSongs()[0]].filePath; ;
            
            if (_currentSongPlayingPath == null || _currentSongPlayingPath != playPath)
            {
                PlaySong(FindSelectedSongs()[0]);
            }

            if (_mp.Media != null)
            {    
                buttonPause.Visible = true;
                buttonPlay.Visible = false;
                _mp.Play();
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

          if (dataGridViewFileList.SelectedRows.Count == 1)
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo);
                
                if (confirmResult == DialogResult.Yes)
                {
                    var trackID = Int32.Parse(dataGridViewFileList.CurrentRow.Cells["TrackIDColumn"].Value.ToString());
                    var filePath = dataGridViewFileList.CurrentRow.Cells["FilePathColumn"].Value.ToString();
                    File.Delete(filePath);
                    dataGridViewFileList.CurrentRow.Visible = false;
                    int trackIndex = 0;

                    for (int i = 0; i <= songStorage.Count - 1; i++)
                    {
                        if (songStorage[i].trackID == trackID)
                        {
                            trackIndex = i;
                        }
                    }

                    songStorage.RemoveAt(trackIndex);
                }
                
            }


        }


        private void buttonPause_Click(object sender, EventArgs e)
        {
            //UI feature to make pause and play buttons overlap
            buttonPause.Visible = false;
            buttonPlay.Visible = true;

            _mp.Pause();
        }
        private void buttonTag_Click(object sender, EventArgs e)
        {
            if (RemoveSelected == null)
            {

                RemoveSelected = new RemoveText(this);
                RemoveSelected.StartPosition = FormStartPosition.CenterScreen;
                RemoveSelected.Show();
            }
        }

        // when adding custom albums, this will need a new form to go to, or we will have to display user made albums on screen in their own list.
        private void buttonFolder_Click(object sender, EventArgs e)
        {

            string[] selectedFiles;

            DialogResult dialogResult = this.openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                selectedFiles = this.openFileDialog.FileNames;

                foreach (string file in selectedFiles)
                {
                    if (file.Contains(".mp3"))
                    {
                        bool duplicate = false;
                        AudioFile tfile = new AudioFile(file, trackID++);
                        // make sure we don't have that file already
                        foreach(AudioFile song in songStorage)
                        {
                            if (song.CompareTo(tfile) == 0)
                            { duplicate = true; }
                        }

                        if(!duplicate)
                        {
                            songStorage.Add(tfile);
                            
                            
                            // check for track sequence
                            if (tfile.Sequence != 0)
                            {

                                // loop through every set
                                foreach (List<AudioFile> audioBookSeries in AudioBookSets)
                                {
                                    //if we find the same album name, add the audiobook and break out of the loop
                                    if (audioBookSeries[0].Album == tfile.Album)
                                    {
                                        audioBookSeries.Add(tfile);
                                        audioBookSeries.Sort((a,b) => { return a.Sequence.CompareTo(b.Sequence); }); // really doubt this is necessary, but there may be a chance.
                                        break;
                                    }
                                    // if we are on the last audioseries, and the previous line did not work, add a new set
                                    if (audioBookSeries == AudioBookSets[AudioBookSets.Count - 1])
                                    {
                                        List<AudioFile> Series = new List<AudioFile>();
                                        Series.Add(tfile);
                                        AudioBookSets.Add(Series);
                                        break;
                                    }
                                }

                                // if there are no audiobooksets already, make a new one
                                if (AudioBookSets.Count == 0)
                                {
                                    List<AudioFile> Series = new List<AudioFile>();
                                    Series.Add(tfile);
                                    AudioBookSets.Add(Series);
                                }
                            }
                        }
                    }
                    RefreshData();
                    

                }
            }
        }
        public void RefreshData()
        {
            dataGridViewFileList.Rows.Clear();
            foreach (AudioFile tfile in songStorage)
            {
                dataGridViewFileList.Rows.Add(tfile.ReturnRowColumnData());
            }
            dataGridViewFileList.Sort(dataGridViewFileList.Columns["SequenceColumn"], ListSortDirection.Ascending);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // if the song is not 0% played, reset to 0
            if (_mp.Position != 0.0)
            { _mp.Position = 0.0F; }

            if (dataGridViewFileList.Rows.Count < 1)
            { return; } // if no folder has been selected, then this prevents out of bounds exceptions

            //Back button to change song being played.
            if (currentsongIndex != 0)
            {
                dataGridViewFileList.Rows[currentsongIndex].Selected = false;
                currentsongIndex--;
                dataGridViewFileList.Rows[currentsongIndex].Selected = true;
                PlaySong(currentsongIndex);

            }

            //If song being played is the first song in the list. The index will be moved to the last song in the list.
            else if (currentsongIndex == 0)
            {
                dataGridViewFileList.Rows[currentsongIndex].Selected = false;
                currentsongIndex = dataGridViewFileList.Rows.Count - 1;
                dataGridViewFileList.Rows[currentsongIndex].Selected = true;

                PlaySong(currentsongIndex);
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (dataGridViewFileList.Rows.Count < 1)
            { return; } // if no folder has been selected, then this prevents out of bounds exceptions

            //Plays next song in list
            if (currentsongIndex != dataGridViewFileList.Rows.Count - 1)
            {
                dataGridViewFileList.Rows[currentsongIndex].Selected = false;
                currentsongIndex++;
                dataGridViewFileList.Rows[currentsongIndex].Selected = true;

                PlaySong(currentsongIndex);

            }

            //If song being played is the last song in the list. Moves index to beginning of list.
            else if (currentsongIndex == dataGridViewFileList.Rows.Count - 1)
            {

                dataGridViewFileList.Rows[currentsongIndex].Selected = false;
                currentsongIndex = 0;
                dataGridViewFileList.Rows[currentsongIndex].Selected = true;

                PlaySong(currentsongIndex);
            }
        }


        // We need some method to display to the user what song is being played and how long into the song they are. I have not since there is no room
        private void PlaySong(int index)
        {
            string playPath = (string)dataGridViewFileList.Rows[index].Cells["FilePathColumn"].Value;
            //string playPath = string.Format(@"{0}", songStorage[index].GetFilePath());
            Media media;
           
            if (_currentSongPlayingPath == null || _currentSongPlayingPath != playPath)
            {
                _currentSongPlayingPath = playPath;
                media = new Media(_libVLC, playPath);
                _mp.Play(media);
                media.Dispose();


                currentsongIndex = index;
            }



            buttonPlay.PerformClick();

        }

        private void ClearSong()
        {
            //outputDevice.Stop();
            if (_currentSongPlayingPath != null)
            { _currentSongPlayingPath = ""; }
            buttonPause.Visible = false;
            buttonPlay.Visible = true;
            _mp.Stop();
        }

        

        private void buttonSaveDVGFields_Click(object sender, EventArgs e)
        {
            //name, artist, track, album, duration, filepath, trackid
            var dataRowsInDGV = dataGridViewFileList.Rows;

            _mp.Stop();
            ClearSong();

            for (int i = 0; i <= dataRowsInDGV.Count - 1; i++)
            {
                foreach (var track in songStorage)
                {

                    if (track.trackID == Int32.Parse(dataRowsInDGV[i].Cells["TrackIDColumn"].Value.ToString()))
                    {
                        try
                        {
                            track.Sequence = uint.Parse(dataRowsInDGV[i].Cells["SequenceColumn"].Value.ToString());
                        }
                        catch (System.FormatException) { }
                        



                    track.Artist = dataRowsInDGV[i].Cells["ArtistColumn"].Value.ToString();
                        track.TrackTitle = dataRowsInDGV[i].Cells["TrackColumn"].Value.ToString();
                        track.Album = dataRowsInDGV[i].Cells["AlbumColumn"].Value.ToString();
                    }
                }
            }
            
        }

        // Can be used to mass rename tags as well
        public List<int> FindAllWithString(string input, string columnName)
        { // columnName ex: "AlbumColumn"
            List<int> songsToRemove = new List<int>();
            for (int i = 0; i < dataGridViewFileList.RowCount; i++)
            {
                string name = dataGridViewFileList.Rows[i]
                                .Cells[columnName].Value.ToString();
                if (name.Contains(input))
                {
                    songsToRemove.Add(i);
                }
            }
            return songsToRemove;
        }
        public string CheckForNamingConflict(string newName)
        {
            string tempName = newName;
            newName = newName.Substring(0, newName.LastIndexOf(@".mp3"));
            
            bool repeat = true; ;
            int i = 0;
            string[] files = System.IO.Directory.GetFiles(newName.Substring(0,newName.LastIndexOf(@"\")));
            while (repeat)
            {
                foreach (string file in files)
                {
                    if (file == tempName)
                    {
                        i++;
                        tempName = newName + "(" + i + ")" + ".mp3";
                        repeat = true;
                        break;
                    }
                    repeat = false;
                }
                

                
            }
            if (!(tempName.Contains(".mp3")))
            {
                tempName += ".mp3";
            }
            return tempName;
        }

        public void RemoveNameElement(string input, List<int> Songs)
        { 
            foreach(int songLocation in Songs)
            {
                string name = dataGridViewFileList.Rows[songLocation]
                                .Cells["FileNameColumn"].Value.ToString();
                if (name.Contains(input))
                {
                    // while there is still more of the phrase to be removed
                    while(name.IndexOf(input) != -1)
                    {
                        // remove it
                        name = name.Remove(name.IndexOf(input), input.Length);
                        //if nothing is left
                        if(name == "" )
                        { // generic naming system
                            name = GetTagBasedName(songLocation);

                            // if there are no tags
                            if (name == "")
                            {
                                
                                name = "Unknown " + 
                                    "(" + 
                                    dataGridViewFileList.Rows[songLocation]
                                        .Cells["FileNameColumn"].Value.GetHashCode() + 
                                    ")";
                            }
                        }
                    }
                    // copy out the old path
                    string oldPath = 
                        dataGridViewFileList.Rows[songLocation]
                                .Cells["FilePathColumn"].Value.ToString();
                    
                    // get only the path
                    string newPath = oldPath.Substring(0, oldPath.LastIndexOf(@"\"));
                    // add the new name and .mp3 back in
                     newPath = string.Format(@"{0}\{1}.mp3", newPath, name);

                    buttonPause.PerformClick();
                    _mp.Stop();
                    // "move" which usually is also rename
                    newPath = CheckForNamingConflict(newPath);
                    System.IO.File.Move(oldPath, newPath);

                    // this is to update the datagrid with the new filepath
                    List<int> find = FindSongsInDataGrid(songStorage);
                    for (int i = 0; i < find.Count; i++)
                    {
                        if(songLocation == find[i])
                        { songStorage[i].filePath = newPath; }
                    }
                }
            }
            RefreshData();
        }
        public string TitleCase(string toTitle)
        {
            string First = toTitle[0].ToString().ToUpper();
            toTitle = toTitle.Remove(0,1);
            toTitle = string.Format("{0}{1}", First, toTitle);

            return toTitle;
        }
        public string GetTagBasedName(int songLocation)
        {
            string edit =
                TitleCase(
                dataGridViewFileList.Rows[songLocation]
                .Cells["ArtistColumn"].Value.ToString()) + " - " +

                TitleCase(
                dataGridViewFileList.Rows[songLocation]
                .Cells["AlbumColumn"].Value.ToString()) + " - " +

                TitleCase(
                dataGridViewFileList.Rows[songLocation]
                .Cells["TrackColumn"].Value.ToString());
            return edit;
        }

        private List<int> FindSelectedSongs()
        {
            List<int> selectedSongs = new List<int>(); 
            List<int> selectedRows = new List<int>();

            for (int i = 0; i < dataGridViewFileList.SelectedCells.Count; i++)
            { selectedRows.Add(dataGridViewFileList.SelectedCells[i].RowIndex); }

            for (int x = 0; x < selectedRows.Count; x++)
            {
                string TrackId = dataGridViewFileList.Rows[selectedRows[x]].Cells["TrackIDColumn"].Value.ToString();
                for (int i = 0; i < songStorage.Count; i++)
                {
                    //AudioFile tfile in songStorage
                    if (songStorage[i].trackID.ToString() == TrackId)
                    { 
                        selectedSongs.Add(i);
                        break;
                    }
                }
            }
            return selectedSongs;

        }
        private List<int> FindSongsInDataGrid(List<AudioFile> audioSet)
        {
            List<int> SongRows = new List<int>();

            for (int i = 0; i < dataGridViewFileList.Rows.Count; i++)
            {
                string TrackId = dataGridViewFileList.Rows[i].Cells["TrackIDColumn"].Value.ToString();
                for (int x = 0; x < audioSet.Count; x++)
                {
                    if (audioSet[x].trackID.ToString() == TrackId)
                    { SongRows.Add(i); }
                }

                
            }
            return SongRows;
        }

        private void albumTagChange_Click(object sender, EventArgs e)
        { 
            //Process.Start("");
        }

        private void artistTagChange_Click(object sender, EventArgs e)
        {
            //Process.Start("");
        }

        private void commentTagChange_Click(object sender, EventArgs e)
        {
            //Process.Start("");
        }

        private void genreTagChange_Click(object sender, EventArgs e)
        {
            //Process.Start("");
        }
        private void sequenceTagChange_Click(object sender, EventArgs e)
        {
            //Process.Start("");
        }

        private void titleTagChange_Click(object sender, EventArgs e)
        {
            //Process.Start("");
        }

        private void rightClickMainForm_Opening(object sender, CancelEventArgs e)
        {
            FormMain_Click(sender, e);
        }

        private void dataGridViewFileList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (songStorage.Count == 0)
            { return; }
            // This line Errors because otherwise this can freeze the program
            //if (dataGridViewFileList.SelectedRows.Contains(dataGridViewFileList.Rows[dataGridViewFileList.TopLeftHeaderCell.RowIndex]))
            //{
            //
            //}
            PlaySong(FindSelectedSongs()[0]);
        }

        private void FormMain_Click(object sender, EventArgs e)
        {

        }

        private void rightClickMainForm_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void playFile_Click(object sender, EventArgs e)
        {
            if(songStorage.Count == 0)
            { return; }
            PlaySong(FindSelectedSongs()[0]);
        }

        private void pauseFile_Click(object sender, EventArgs e)
        {
            if (_mp.IsPlaying)
            {
                buttonPause.PerformClick();
            }
        }
        private void ClearTable_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure to clear the table?", "Confirm Clear", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                ClearSong();
                _mp.Stop();
                songStorage.Clear();
                dataGridViewFileList.Rows.Clear();
            }
        }

        private void dataGridViewFileList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridViewFileList.HitTest(e.X, e.Y);

                if (hti.RowIndex != -1)
                {
                    dataGridViewFileList.ClearSelection();
                    dataGridViewFileList.Rows[hti.RowIndex].Selected = true;
                    dataGridViewFileList.CurrentCell = dataGridViewFileList.Rows[hti.RowIndex].Cells[0];
                }
            }
        }

        private void dataGridViewFileList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            for (int i = 0; i < AudioBookSets.Count; i++)
            {
                List<int> SongsToRemove = FindSongsInDataGrid(AudioBookSets[i]);
                SongsToRemove.Sort();
                int offset = 0;
                for (int x = 0; x < SongsToRemove.Count; x++)
                {
                    dataGridViewFileList.Rows.RemoveAt(SongsToRemove[x] + offset);
                    offset--;
                }
                for (int x = 0; x < AudioBookSets[i].Count; x++)
                {
                    dataGridViewFileList.Rows.Add(AudioBookSets[i][x].ReturnRowColumnData());
                }


            }
        }


    }
}
