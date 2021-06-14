using TagLib;
namespace MusicManager
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMusicControls = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonTag = new System.Windows.Forms.Button();
            this.buttonSaveDGVFields = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.dataGridViewFileList = new System.Windows.Forms.DataGridView();
            this.Sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightClickMainForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playFile = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tagChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.albumTagChange = new System.Windows.Forms.ToolStripMenuItem();
            this.artistTagChange = new System.Windows.Forms.ToolStripMenuItem();
            this.commentTagChange = new System.Windows.Forms.ToolStripMenuItem();
            this.genreTagChange = new System.Windows.Forms.ToolStripMenuItem();
            this.sequenceTagChange = new System.Windows.Forms.ToolStripMenuItem();
            this.titleTagChange = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.deleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelMusicControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).BeginInit();
            this.rightClickMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMusicControls
            // 
            this.panelMusicControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.panelMusicControls.Controls.Add(this.buttonSave);
            this.panelMusicControls.Controls.Add(this.buttonDelete);
            this.panelMusicControls.Controls.Add(this.buttonForward);
            this.panelMusicControls.Controls.Add(this.buttonPause);
            this.panelMusicControls.Controls.Add(this.buttonBack);
            this.panelMusicControls.Controls.Add(this.buttonTag);
            this.panelMusicControls.Controls.Add(this.buttonSaveDGVFields);
            this.panelMusicControls.Controls.Add(this.buttonPlay);
            this.panelMusicControls.Controls.Add(this.buttonFolder);
            this.panelMusicControls.Location = new System.Drawing.Point(-4, 0);
            this.panelMusicControls.Margin = new System.Windows.Forms.Padding(1);
            this.panelMusicControls.Name = "panelMusicControls";
            this.panelMusicControls.Size = new System.Drawing.Size(606, 53);
            this.panelMusicControls.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = global::MusicManager.Properties.Resources.floppy_disk;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(508, 11);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(46, 30);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::MusicManager.Properties.Resources.delete;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(559, 10);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(46, 30);
            this.buttonDelete.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonDelete, "Highlight a single row for deletion.");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.BackgroundImage = global::MusicManager.Properties.Resources._038_next_button;
            this.buttonForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonForward.FlatAppearance.BorderSize = 0;
            this.buttonForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForward.Location = new System.Drawing.Point(326, 13);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(1);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(35, 25);
            this.buttonForward.TabIndex = 0;
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackgroundImage = global::MusicManager.Properties.Resources._037_pause_button;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Location = new System.Drawing.Point(328, 10);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPause.Location = new System.Drawing.Point(289, 7);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(40, 50);
            this.buttonPause.Size = new System.Drawing.Size(35, 37);
            this.buttonPause.TabIndex = 0;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Visible = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::MusicManager.Properties.Resources._036_previous_track;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(248, 13);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(1);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(35, 25);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonTag
            // 
            this.buttonTag.BackgroundImage = global::MusicManager.Properties.Resources.supermarket;
            this.buttonTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTag.FlatAppearance.BorderSize = 0;
            this.buttonTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTag.Location = new System.Drawing.Point(377, 11);
            this.buttonTag.Margin = new System.Windows.Forms.Padding(1);
            this.buttonTag.Name = "buttonTag";
            this.buttonTag.Size = new System.Drawing.Size(46, 30);
            this.buttonTag.TabIndex = 0;
            this.buttonTag.UseVisualStyleBackColor = true;
            this.buttonTag.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonSaveDGVFields
            // 
            this.buttonSaveDGVFields.BackgroundImage = global::MusicManager.Properties.Resources.savetable4;
            this.buttonSaveDGVFields.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSaveDGVFields.FlatAppearance.BorderSize = 0;
            this.buttonSaveDGVFields.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonSaveDGVFields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSaveDGVFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDGVFields.Location = new System.Drawing.Point(435, 5);
            this.buttonSaveDGVFields.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSaveDGVFields.Name = "buttonSaveDGVFields";
            this.buttonSaveDGVFields.Size = new System.Drawing.Size(57, 41);
            this.buttonSaveDGVFields.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonSaveDGVFields, "Saves all edits made in the table.");
            this.buttonSaveDGVFields.UseVisualStyleBackColor = true;
            this.buttonSaveDGVFields.Click += new System.EventHandler(this.buttonSaveDVGFields_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = global::MusicManager.Properties.Resources._039_play_button;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Location = new System.Drawing.Point(289, 7);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(35, 37);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonFolder
            // 
            this.buttonFolder.BackgroundImage = global::MusicManager.Properties.Resources.folder;
            this.buttonFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFolder.FlatAppearance.BorderSize = 0;
            this.buttonFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFolder.Location = new System.Drawing.Point(13, 11);
            this.buttonFolder.Margin = new System.Windows.Forms.Padding(1);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(46, 30);
            this.buttonFolder.TabIndex = 0;
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // dataGridViewFileList
            // 
            this.dataGridViewFileList.AllowUserToAddRows = false;
            this.dataGridViewFileList.AllowUserToDeleteRows = false;
            this.dataGridViewFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sequence,
            this.FileNameColumn,
            this.ArtistColumn,
            this.TrackColumn,
            this.AlbumColumn,
            this.DurationColumn,
            this.FilePathColumn,
            this.TrackIDColumn});
            this.dataGridViewFileList.Location = new System.Drawing.Point(-1, 48);
            this.dataGridViewFileList.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridViewFileList.Name = "dataGridViewFileList";
            this.dataGridViewFileList.RowHeadersWidth = 20;
            this.dataGridViewFileList.RowTemplate.Height = 29;
            this.dataGridViewFileList.Size = new System.Drawing.Size(603, 304);
            this.dataGridViewFileList.TabIndex = 2;
            this.dataGridViewFileList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFileList_CellMouseDoubleClick);
            this.dataGridViewFileList.ColumnSortModeChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewFileList_ColumnSortModeChanged);
            this.dataGridViewFileList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewFileList_MouseDown);
            // 
            // Sequence
            // 
            this.Sequence.HeaderText = "#";
            this.Sequence.Name = "Sequence";
            this.Sequence.Width = 25;
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileNameColumn.HeaderText = "Name";
            this.FileNameColumn.MinimumWidth = 6;
            this.FileNameColumn.Name = "FileNameColumn";
            this.FileNameColumn.ReadOnly = true;
            // 
            // ArtistColumn
            // 
            this.ArtistColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArtistColumn.HeaderText = "Artist";
            this.ArtistColumn.MinimumWidth = 6;
            this.ArtistColumn.Name = "ArtistColumn";
            // 
            // TrackColumn
            // 
            this.TrackColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrackColumn.HeaderText = "Track";
            this.TrackColumn.MinimumWidth = 6;
            this.TrackColumn.Name = "TrackColumn";
            // 
            // AlbumColumn
            // 
            this.AlbumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlbumColumn.HeaderText = "Album";
            this.AlbumColumn.MinimumWidth = 6;
            this.AlbumColumn.Name = "AlbumColumn";
            // 
            // DurationColumn
            // 
            this.DurationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DurationColumn.HeaderText = "Duration";
            this.DurationColumn.MinimumWidth = 6;
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.ReadOnly = true;
            this.DurationColumn.Width = 78;
            // 
            // FilePathColumn
            // 
            this.FilePathColumn.HeaderText = "FilePath";
            this.FilePathColumn.MinimumWidth = 6;
            this.FilePathColumn.Name = "FilePathColumn";
            this.FilePathColumn.ReadOnly = true;
            this.FilePathColumn.Visible = false;
            this.FilePathColumn.Width = 125;
            // 
            // TrackIDColumn
            // 
            this.TrackIDColumn.HeaderText = "TrackID";
            this.TrackIDColumn.MinimumWidth = 6;
            this.TrackIDColumn.Name = "TrackIDColumn";
            this.TrackIDColumn.ReadOnly = true;
            this.TrackIDColumn.Visible = false;
            this.TrackIDColumn.Width = 125;
            // 
            // rightClickMainForm
            // 
            this.rightClickMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playFile,
            this.pauseFile,
            this.tagChangeMenu,
            this.deleteFile});
            this.rightClickMainForm.Name = "contextMenuStrip1";
            this.rightClickMainForm.Size = new System.Drawing.Size(186, 70);
            this.rightClickMainForm.Opening += new System.ComponentModel.CancelEventHandler(this.rightClickMainForm_Opening);
            this.rightClickMainForm.Click += new System.EventHandler(this.playFile_Click);
            this.rightClickMainForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rightClickMainForm_MouseClick);
            // 
            // playFile
            // 
            this.playFile.Name = "playFile";
            this.playFile.Size = new System.Drawing.Size(185, 22);
            this.playFile.Text = "Play";
            this.playFile.Click += new System.EventHandler(this.playFile_Click);
            // 
            // pauseFile
            // 
            this.pauseFile.Name = "pauseFile";
            this.pauseFile.Size = new System.Drawing.Size(185, 22);
            this.pauseFile.Text = "Pause";
            this.pauseFile.Click += new System.EventHandler(this.pauseFile_Click);
            // 
            // tagChangeMenu
            // 
            this.tagChangeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumTagChange,
            this.artistTagChange,
            this.commentTagChange,
            this.genreTagChange,
            this.sequenceTagChange,
            this.titleTagChange});
            this.tagChangeMenu.Name = "tagChangeMenu";
            this.tagChangeMenu.Size = new System.Drawing.Size(185, 22);
            this.tagChangeMenu.Text = "Change Tags of Song";
            // 
            // albumTagChange
            // 
            this.albumTagChange.Name = "albumTagChange";
            this.albumTagChange.Size = new System.Drawing.Size(149, 22);
            this.albumTagChange.Text = "Album Tag";
            // 
            // artistTagChange
            // 
            this.artistTagChange.Name = "artistTagChange";
            this.artistTagChange.Size = new System.Drawing.Size(149, 22);
            this.artistTagChange.Text = "Artist Tag";
            // 
            // commentTagChange
            // 
            this.commentTagChange.Name = "commentTagChange";
            this.commentTagChange.Size = new System.Drawing.Size(149, 22);
            this.commentTagChange.Text = "Comment Tag";
            // 
            // genreTagChange
            // 
            this.genreTagChange.Name = "genreTagChange";
            this.genreTagChange.Size = new System.Drawing.Size(149, 22);
            this.genreTagChange.Text = "Genre Tag";
            // 
            // sequenceTagChange
            // 
            this.sequenceTagChange.Name = "sequenceTagChange";
            this.sequenceTagChange.Size = new System.Drawing.Size(149, 22);
            this.sequenceTagChange.Text = "Sequence Tag";
            // 
            // titleTagChange
            // 
            this.titleTagChange.Name = "titleTagChange";
            this.titleTagChange.Size = new System.Drawing.Size(149, 22);
            this.titleTagChange.Text = "Title Tag";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "Album";
            // 
            // deleteFile
            // 
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(217, 24);
            this.deleteFile.Text = "Delete";
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(602, 347);
            this.ContextMenuStrip = this.rightClickMainForm;
            this.Controls.Add(this.dataGridViewFileList);
            this.Controls.Add(this.panelMusicControls);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.FormMain_Click);
            this.panelMusicControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).EndInit();
            this.rightClickMainForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMusicControls;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonTag;
        private System.Windows.Forms.Button buttonSaveDGVFields;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.DataGridView dataGridViewFileList;
        private System.Windows.Forms.ContextMenuStrip rightClickMainForm;
        private System.Windows.Forms.ToolStripMenuItem tagChangeMenu;
        private System.Windows.Forms.ToolStripMenuItem albumTagChange;
        private System.Windows.Forms.ToolStripMenuItem artistTagChange;
        private System.Windows.Forms.ToolStripMenuItem genreTagChange;
        private System.Windows.Forms.ToolStripMenuItem sequenceTagChange;
        private System.Windows.Forms.ToolStripMenuItem titleTagChange;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackIDColumn;
        private System.Windows.Forms.ToolStripMenuItem commentTagChange;
        private System.Windows.Forms.ToolStripMenuItem playFile;
        private System.Windows.Forms.ToolStripMenuItem pauseFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem deleteFile;

    }
}

