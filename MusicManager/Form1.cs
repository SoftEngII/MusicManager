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
        List<AudioFile> songsInFolder = new List<AudioFile>(); // Can be made into a list of a song class, which would have more info, or we can just store reference here as is done already
        
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
            
        }


        private void buttonPause_Click(object sender, EventArgs e)
        {
            //UI feature to make pause and play buttons overlap
            buttonPause.Visible = false;
            buttonPlay.Visible = true;
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            // future potentially required code.
            // Clearing the previous list
            listBoxSelectedFile.Items.Clear();

        string folderpath;
        folderSelectDialogue = new FolderBrowserDialog();
        DialogResult dr = folderSelectDialogue.ShowDialog();
            if (dr == DialogResult.OK)
            {
                folderpath = folderSelectDialogue.SelectedPath;

                //rippp
                string[] files = Directory.GetFiles(folderpath);
                foreach(string file in files)
                {
        // filter only mp3's
                    string song = file.Substring(file.Length-3,3);

                    if (song.Contains("mp3"))
                    {
                        // adding reference to location of the song
                        AudioFile mp3file =
                            new AudioFile
                            (
                                file.Substring(
                                file.LastIndexOf("\\") + 1,
                                file.LastIndexOf(".") - (file.LastIndexOf("\\") + 1)
                                )
                            );
                        songsInFolder.Add(mp3file);
                        // add visual string of the song filename, splitter+1 removes file path, whereas after the comma removes .mp3
                        listBoxSelectedFile.Items.Add(mp3file.Name);


                        // Potential improvement, listBox has multicollumn support. Thus, song, album, and artist can be split respectively
                    }
}
            }
            

        }
    }
}
