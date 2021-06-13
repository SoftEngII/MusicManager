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


namespace MusicManager
{
    public partial class FormMain : Form
    {
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
            this.openFileDialog.Filter = "Albums&mp3s |*.mp3;*.Album|" + "Albums |*.Album";
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

                    //// gets the selected rows index from selected cells and prevents duplicates.

                    //for (int i = 0; i < dataGridViewFileList.GetCellCount(DataGridViewElementStates.Selected); i++)
                    //{
                    //    if (!(allRows.Contains(dataGridViewFileList.SelectedCells[i].RowIndex)))
                    //    {
                    //        allRows.Add(dataGridViewFileList.SelectedCells[i].RowIndex);
                    //    }

                    //}


                    // pull data from dataGridViewFileList to compare to songStorage, since they may not be synchronized 
                    int filePathCollumn = 5;
                    List<string> filePaths = new List<string>();
                    foreach (int row in allRows)
                    {
                        string FilePath = (string)dataGridViewFileList.Rows[row].Cells[filePathCollumn].Value;
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
            if (
                   dataGridViewFileList.SelectedCells.Count == 1 ||
                   dataGridViewFileList.SelectedRows.Count == 1
               )
            {
                buttonPlay.Visible = false;
                buttonPause.Visible = true;
                PlaySong(dataGridViewFileList.CurrentCell.RowIndex);
            }

        }


        private void buttonPause_Click(object sender, EventArgs e)
        {
            //UI feature to make pause and play buttons overlap
            buttonPause.Visible = false;
            buttonPlay.Visible = true;

            _mp.Pause();
        }

        // when adding custom albums, this will need a new form to go to, or we will have to display user made albums on screen in their own list.
        private void buttonFolder_Click(object sender, EventArgs e)
        {
            dataGridViewFileList.Rows.Clear();
            songStorage.Clear();
            trackID = 0;

            string[] selectedFiles;

            DialogResult dialogResult = this.openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                selectedFiles = this.openFileDialog.FileNames;

                foreach (string file in selectedFiles)
                {
                    if (file.Contains(".mp3"))
                    {
                        AudioFile tfile = new AudioFile(file, trackID++);
                        songStorage.Add(tfile);
                        dataGridViewFileList.Rows.Add(tfile.ReturnRowColumnData());

                    }
                }
            }
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
            string playPath = (string)dataGridViewFileList.Rows[index].Cells[5].Value; //5 is the same number from saveFile, so an enum or array may be nice soon
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



            _mp.Play();

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

        private void rightClickMainForm_Opening(object sender, CancelEventArgs e)
        {

        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            //rows into list -> cols into list -> in dividual index of cols.
            //name artist track album duration TrackID
            //name, artist, track, album, duration, filepath, trackid

            var numOfColumns = dataGridViewFileList.ColumnCount;
            var selCol = dataGridViewFileList.CurrentRow.Cells;
            var trackID = selCol[numOfColumns - 1].Value.ToString();
            var selectedTrackID = Int32.Parse(trackID);
            //working here to access each column I want by it's name.
            foreach (DataGridViewRow row in dataGridViewFileList.Rows)
            {
                if (object.Equals(row.Cells[ArtistColumn.Index].Value, 123))
                {

                }

                //foreach (var item in songStorage)
                //{
                //    MessageBox.Show(item.trackID.ToString());
                //    //if (item.trackID == selectedTrackID)
                //    //{
                //    //    item.Artist = "New Artist";
                //    //    item.TrackTitle = "New Track Title";
                //    //    item.Album = "New Album";
                //    //}
                //}
            }
        }

        // no care for current selection because it is not mentioned on the sheet
        private void RemoveNameElement(string input)
        { // Untested Code
            foreach(AudioFile tfile in songStorage)
            {
                string name = tfile.ReturnFileName();
                if(name.Contains(input))
                {
                    // while there is still more of the phrase to be removed
                    while(name.IndexOf(input) != -1)
                    {
                        // remove it
                        name = name.Remove(name.IndexOf(input), input.Length);
                        //if nothing is left
                        if(name == "" )
                        {
                            name = tfile.Artist + " - " + tfile.Album + " - " + tfile.TrackTitle;
                            // if there are no tags
                            if(name == "")
                            {
                                
                                name = "Unknown " + "(" + tfile.ReturnFileName().Length + ")";
                            }
                        }
                    }
                    // create the paths
                    string oldPath = tfile.GetFilePath();
                    string newPath = oldPath
                        .Remove(oldPath.IndexOf(tfile.ReturnFileName()),
                                (oldPath.Length - oldPath.LastIndexOf(@"\"))
                                );

                    // "move" which usually is also rename
                    System.IO.File.Move(oldPath, newPath);
                }
            }
        }
        private List<int> FindSelectedSongs()
        {
            List<int> selectedSongs = new List<int>(); 
            List<int> selectedRows = new List<int>();

            for (int i = 0; i < dataGridViewFileList.SelectedCells.Count; i++)
            { selectedRows.Add(dataGridViewFileList.SelectedCells[i].RowIndex); }

            for (int x = 0; x < selectedRows.Count; x++)
            {
                string TrackId = dataGridViewFileList.Rows[selectedRows[x]].Cells[6].Value.ToString();
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
        private void dataGridViewFileList_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e) 
        {
            //songStorage.Clear();
            //for (int i = 0; i < dataGridViewFileList.Rows.Count; i++)
            //{
            //    AudioFile tfile = new AudioFile(dataGridViewFileList.Rows[i].Cells[5].Value.ToString(), 0);
            //    songStorage.Add(tfile);
            //}
        }
    }
}
