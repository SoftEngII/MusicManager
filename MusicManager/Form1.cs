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

namespace MusicManager
{
    public partial class FormMain : Form
    {
        private int currentsongIndex;
        private bool ascendingOrder;
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        List<AudioFile> songStorage = new List<AudioFile>();
        private bool ascSorted = false;

        public FormMain()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //UI feature to make pause and play buttons overlap
            

            if (dataGridViewFileList.RowCount != 0 && dataGridViewFileList.SelectedRows.Count == 1)
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

            Player.controls.pause();
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {

            ascendingOrder = false;
            dataGridViewFileList.Rows.Clear();
            
            songStorage.Clear();
            string folderpath;
            folderSelectDialogue = new FolderBrowserDialog();
            DialogResult dr = folderSelectDialogue.ShowDialog();

            if (dr == DialogResult.OK)
            {
                folderpath = folderSelectDialogue.SelectedPath;


                string[] files = Directory.GetFiles(folderpath);

                foreach (string file in files)
                {
                    if (file.Contains(".mp3"))
                    {
                        AudioFile tfile = new AudioFile(file);
                        songStorage.Add(tfile);
                        dataGridViewFileList.Rows.Add(tfile.RowData());
                         
                    }
                }
                Sort();
            }


        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            Sort();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
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

        private void Sort()
        {
            
            if (ascSorted == false)
            {
                dataGridViewFileList.Sort(ArtistColumn, ListSortDirection.Ascending);
                ascSorted = true;
            }
            else if (ascSorted)
            {
                dataGridViewFileList.Sort(ArtistColumn, ListSortDirection.Descending);
                ascSorted = false;
            }


        }
        private void PlaySong(int index)
        {

            string playPath = string.Format(@"{0}", songStorage[index].GetName());

            if (Player.URL != playPath)
            {
                Player.URL = playPath;
                currentsongIndex = index;
            }

            Player.controls.play();
        }

        private void listBoxSelectedFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
