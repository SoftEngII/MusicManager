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
        ContextMenuStrip rightClick = new ContextMenuStrip();
        private int currentsongIndex;
        private bool ascendingOrder;
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        List<AudioFile> songStorage = new List<AudioFile>();

        public FormMain()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //UI feature to make pause and play buttons overlap
            buttonPlay.Visible = false;
            buttonPause.Visible = true;

            if (listBoxSelectedFile.Items.Count != 0 && listBoxSelectedFile.SelectedIndex != -1)
            {
                PlaySong(listBoxSelectedFile.SelectedIndex);
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
            listBoxSelectedFile.Items.Clear();
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
                        listBoxSelectedFile.Items.Add(tfile.ToString()); 
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
            if( currentsongIndex != 0)
            {
                currentsongIndex--;
                PlaySong(currentsongIndex);
                listBoxSelectedFile.SelectedIndex = currentsongIndex;
            }
        }
        private void buttonForward_Click(object sender, EventArgs e)
        {
            // If you are on the last song on the list, press the sort button, then button forward, it resets you to the top of the list and continues playing the song, pressing it again fixes this. Not really a bug though.
            if (currentsongIndex+1 < songStorage.Count)
            {
                currentsongIndex++;
                PlaySong(currentsongIndex);
                listBoxSelectedFile.SelectedIndex = currentsongIndex;
            } else
            {
                currentsongIndex = 0;
                PlaySong(currentsongIndex);
                listBoxSelectedFile.SelectedIndex = currentsongIndex;
            }
        }

        private void Sort()
        {
            if (ascendingOrder == true)
            {
                ascendingOrder = false;
                songStorage.Sort();
                listBoxSelectedFile.Items.Clear();
                foreach (AudioFile tfile in songStorage)
                {
                    listBoxSelectedFile.Items.Add(tfile.ToString());
                }
            }
            else
            {
                ascendingOrder = true;

                songStorage.Reverse();
                listBoxSelectedFile.Items.Clear();
                foreach (AudioFile tfile in songStorage)
                {
                    listBoxSelectedFile.Items.Add(tfile.ToString());
                }
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
