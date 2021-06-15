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
        private readonly FormMain PrimaryForm;
        public RemoveText(FormMain form1)
        {
            this.PrimaryForm = form1;
            InitializeComponent();
            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult;
            if(this.RemoveBox.Text == "")
            {
                confirmResult = MessageBox.Show("Deleting Hard Drive, please enter a value next time.","Deleting All", MessageBoxButtons.OK);
                return;
            }
            List<int> songsToRemove = PrimaryForm.FindAllWithString(this.RemoveBox.Text, "FileNameColumn");
            switch(songsToRemove.Count)
            {
                case 0:
                    confirmResult = MessageBox.Show("There are no names with the phrase: \"" + this.RemoveBox.Text + "\"", "Not Found", MessageBoxButtons.OK);
                break;
                
                case 1:
                    confirmResult = MessageBox.Show("There is " + songsToRemove.Count +
                                            " name with the phrase:  \"" + this.RemoveBox.Text + "\"",
                                            "Are you sure?", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        PrimaryForm.RemoveNameElement(this.RemoveBox.Text, songsToRemove);
                        this.Dispose();
                    } 
                break;
                
                    // pretty sure there is no way for the count to be anything but these
                default:
                    confirmResult = MessageBox.Show("There are " + songsToRemove.Count +
                                           " names with the phrase:  \"" + this.RemoveBox.Text + "\"",
                                           "Are you sure?", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        if (confirmResult == DialogResult.Yes)
                        {
                            PrimaryForm.RemoveNameElement(this.RemoveBox.Text, songsToRemove);
                            this.Dispose();
                        }
                    }
                break;
            }
        }
    }
}
