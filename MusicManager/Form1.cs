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
using NAudio.Wave;


namespace MusicManager
{
    public partial class FormMain : Form
    {
        private WaveOutEvent outputDevice = new WaveOutEvent();
        private AudioFileReader audioFile;
        private int currentsongIndex;

        List<AudioFile> songStorage = new List<AudioFile>();
        private bool ascSorted = false;

        public FormMain()
        {
            InitializeComponent();
            this.openFileDialog.Filter = "Albums&mp3s (*.mp3;*.Album)|*.mp3;*.Album" + "Mp3 (*.mp3)|*.mp3" + "Albums (*.Album)|*.Album";
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
                if (saveLocation.Substring(saveLocation.Length-6,6) != ".Album")
                { saveLocation += ".Album"; }

                //// All of this gets the path and formats
                //string path = Application.StartupPath;
                //int start = path.IndexOf(@"bin");
                //path = string.Format(@"{0}Albums\{1}.txt", path.Substring(0, start), saveLocation);

                // Takes User selected songs and places them into text file

                StreamWriter newAlbum = System.IO.File.CreateText(saveLocation);
                
                // gets the selected rows index from selected cells and prevents duplicates.
                List<int> allRows = new List<int>();
                for(int i = 0; i  < dataGridViewFileList.GetCellCount(DataGridViewElementStates.Selected); i++) {
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
                    string FilePath =  (string)dataGridViewFileList.Rows[row].Cells[filePath].Value;
                    //AudioFile song =  (AudioFile)dataGridViewFileList.Rows[row].Cells[artistVal].Value;
                    //filePaths.Add(song.GetFilePath());
                            filePaths.Add(FilePath);

                }

                // Write the song path into the text file on it's own line
                foreach(string filepath in filePaths)
                {
                    //AudioFile song = (AudioFile)dataGridViewFileList.Rows[songRow].DataBoundItem;
                    //dataGridViewFileList.Rows[songRow].DataBoundItem.ToString();
                        newAlbum.WriteLine(filepath);
                    
                    
                    //newAlbum.WriteLine(songStorage[songRow].GetFilePath());
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

            outputDevice?.Stop();
        }

        // when adding custom albums, this will need a new form to go to, or we will have to display user made albums on screen in their own list.
        private void buttonFolder_Click(object sender, EventArgs e)
        {
            dataGridViewFileList.Rows.Clear();
            songStorage.Clear();
            // Clear song is temporarily removed since we need to be able to make albums with more than just a specified set of songs
            //ClearSong();

            string[] files;

            
            //this.openFileDialog = new OpenFileDialog();
            DialogResult dr = this.openFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                files = this.openFileDialog.FileNames;


                //string[] files = Directory.GetFiles(folderpath);

                foreach (string file in files)
                {
                    if (file.Contains(".mp3"))
                    {
                        AudioFile tfile = new AudioFile(file);
                        songStorage.Add(tfile);
                        dataGridViewFileList.Rows.Add(tfile.RowData());

                    }
                    //this.dataGridViewFileList.DataSource = songStorage; not a functional alternative
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

            string playPath = string.Format(@"{0}", songStorage[index].GetFilePath());

            if (audioFile == null || audioFile.FileName != playPath)
            {
                if(audioFile != null) 
                { 
                    audioFile.Dispose();
                   
                }
                
                audioFile = new AudioFileReader(playPath);
                outputDevice.Stop();
                outputDevice.Init(audioFile);
                //Player.URL = playPath;
                currentsongIndex = index;
            }

            outputDevice.Play();
        }

        private void ClearSong()
        {
            outputDevice.Stop();
            if (audioFile != null)
            { audioFile.Dispose(); }
            buttonPause.Visible = false;
            buttonPlay.Visible = true;
        }

        private void rightClickMainForm_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
