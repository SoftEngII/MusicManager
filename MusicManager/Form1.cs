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
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        //List<string> songsInFolder = new List<string>(); // Can be made into a list of a song class, which would have more info, or we can just store reference here as is done already
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

            if (listBoxSelectedFile.Items.Count != 0 && listBoxSelectedFile.SelectedIndex != -1)//songStorage[0].GetName() != null || songStorage[0].GetName() != ""
            {
                                // *****songStorage reference is BAD for sorting here. Needs changed!!******
                string playPath = string.Format(@"{0}", songStorage[listBoxSelectedFile.SelectedIndex].GetName());

                if (Player.URL != playPath)
                { Player.URL = playPath; }
            }
            Player.controls.play();

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
            }


        }
    }
}
