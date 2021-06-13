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

            this.openFileDialog.Filter = "Albums&mp3s |*.mp3;*.Album|" + "Albums |*.Album";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.saveFileDialog = new SaveFileDialog();
            this.saveFileDialog.DefaultExt = @".Album";
            DialogResult dr = this.saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string saveLocation = this.saveFileDialog.FileName;
                if (saveLocation.Substring(saveLocation.Length - 6, 6) != ".Album")
                { saveLocation += ".Album"; }

                // Takes User selected name and Creates a textFile with that name&extension
                StreamWriter newAlbum = System.IO.File.CreateText(saveLocation);

                // gets the selected rows index from selected cells and prevents duplicates.
                List<int> allRows = new List<int>();
                for (int i = 0; i < dataGridViewFileList.GetCellCount(DataGridViewElementStates.Selected); i++)
                {
                    if (!(allRows.Contains(dataGridViewFileList.SelectedCells[i].RowIndex)))
                    {
                        allRows.Add(dataGridViewFileList.SelectedCells[i].RowIndex);
                    }

                }
                // pull data from dataGridViewFileList to compare to songStorage, since they may not be synchronized 
                int filePath = 5;
                List<string> filePaths = new List<string>();
                foreach (int row in allRows)
                {
                    string FilePath = (string)dataGridViewFileList.Rows[row].Cells[filePath].Value;
                    filePaths.Add(FilePath);

                }

                // Write the song path into the text file on it's own line
                foreach (string filepath in filePaths)
                {
                    newAlbum.WriteLine(filepath);
                }


                newAlbum.Close();
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
            if (dataGridViewFileList.Rows.Count < 1)
            { return; } // if no folder has been selected, then this prevents out of bounds exceptions

            //Back button to change song being played.
            if (currentsongIndex != 0)
            {
                currentsongIndex--;
                PlaySong(currentsongIndex);

            }

            //If song being played is the first song in the list. The index will be moved to the last song in the list.
            else if (currentsongIndex == 0)
            {
                currentsongIndex = dataGridViewFileList.Rows.Count - 1;
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
                currentsongIndex++;
                PlaySong(currentsongIndex);

            }

            //If song being played is the last song in the list. Moves index to beginning of list.
            else if (currentsongIndex == dataGridViewFileList.Rows.Count - 1)
            {
                currentsongIndex = 0;
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
            
        }
    }
}
