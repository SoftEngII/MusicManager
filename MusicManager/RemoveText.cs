using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicManager
{
    public partial class RemoveText : Form
    {
        DialogResult confirmResult;
        private readonly FormMain PrimaryForm;
        public RemoveText(FormMain form1)
        {
            this.PrimaryForm = form1;
            InitializeComponent();
            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            switch(ColumnComboBox.Text)
            {
                case"Name":
                    replaceFileName();
                    break;
                case "Artist":
                    replaceTag("ArtistColumn");
                    break;
                case "Track":
                    replaceTag("TrackColumn");
                    break;
                case "Album":
                    replaceTag("AlbumColumn");
                    break;
                case "Genre":
                    replaceTag("GenreColumn");
                    break;


                default:
                    replaceFileName();
                    break;
            }

        }
        private void replaceTag(string column)
        {
            List<int> songsWithText = PrimaryForm.FindAllWithString(this.FindBox.Text, column);
            List<int> selected = PrimaryForm.FindSelectedSongs();
            List<int> songsToReplace = new List<int>();

            for (int i = 0; i < songsWithText.Count; i++)
            {
                if(selected.Contains(songsWithText[i]))
                { songsToReplace.Add(i); }
            }
            
            switch (songsToReplace.Count)
            {
                case 0:
                    confirmResult = MessageBox.Show("There are no selected  "+ ColumnComboBox.Text + "s with the phrase: \"" + this.FindBox.Text + "\"", "Not Found", MessageBoxButtons.OK);
                    break;

                case 1:
                    confirmResult = MessageBox.Show("There is " + songsToReplace.Count +
                                            " " + ColumnComboBox.Text +" with the phrase:  \"" + this.FindBox.Text + "\"",
                                            "Are you sure?", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        PrimaryForm.ReplaceSelectedColumnData(this.FindBox.Text, this.ReplaceBox.Text, column);
                    }
                    break;
                    
                    
                // pretty sure there is no way for the count to be anything but these
                default:
                    confirmResult = MessageBox.Show("There are " + songsToReplace.Count + " " + 
                                                    ColumnComboBox.Text + "s with the phrase:  \"" + this.FindBox.Text + "\"",
                                                    "Are you sure?", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        if (confirmResult == DialogResult.Yes)
                        {
                            PrimaryForm.ReplaceSelectedColumnData(this.FindBox.Text, this.ReplaceBox.Text, column);
                        }
                    }
                    break;
            }
        }
        private void replaceFileName ()
        {
            //if (this.FindBox.Text == "")
            //{
            //    confirmResult = MessageBox.Show("Deleting Hard Drive, please enter a value next time.", "Deleting All", MessageBoxButtons.OK);
            //    return;
            //}
            List<int> songsToRemove = PrimaryForm.FindAllWithString(this.FindBox.Text, "FileNameColumn");
            switch (songsToRemove.Count)
            {
                case 0:
                    confirmResult = MessageBox.Show("There are no names with the phrase: \"" + this.FindBox.Text + "\"", "Not Found", MessageBoxButtons.OK);
                    break;

                case 1:
                    confirmResult = MessageBox.Show("There is " + songsToRemove.Count +
                                            " name with the phrase:  \"" + this.FindBox.Text + "\"",
                                            "Are you sure?", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        PrimaryForm.ReplaceNameElement(this.FindBox.Text, this.ReplaceBox.Text, songsToRemove);
                    }
                    break;

                // pretty sure there is no way for the count to be anything but these
                default:
                    confirmResult = MessageBox.Show("There are " + songsToRemove.Count +
                                           " names with the phrase:  \"" + this.FindBox.Text + "\"",
                                           "Are you sure?", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        if (confirmResult == DialogResult.Yes)
                        {
                            PrimaryForm.ReplaceNameElement(this.FindBox.Text, this.ReplaceBox.Text, songsToRemove);
                        }
                    }
                    break;
            }
        }

        private void RemoveText_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
