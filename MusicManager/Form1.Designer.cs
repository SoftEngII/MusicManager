using System;
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
            this.currentSongLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.timeProgressBar = new System.Windows.Forms.ProgressBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonTag = new System.Windows.Forms.Button();
            this.buttonSaveDGVFields = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.FindAndReplacePanel = new System.Windows.Forms.Panel();
            this.ReplaceBox = new System.Windows.Forms.TextBox();
            this.FindBox = new System.Windows.Forms.TextBox();
            this.ColumnComboBox = new System.Windows.Forms.ComboBox();
            this.collumnComboBoxLabel = new System.Windows.Forms.Label();
            this.findLabel = new System.Windows.Forms.Label();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.dataGridViewFileList = new System.Windows.Forms.DataGridView();
            this.SequenceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateModifiedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightClickMainForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playFile = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTable = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tagChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.albumTagChange = new System.Windows.Forms.ToolStripMenuItem();
            this.artistTagChange = new System.Windows.Forms.ToolStripMenuItem();
            this.commentTagChange = new System.Windows.Forms.ToolStripMenuItem();
            this.genreTagChange = new System.Windows.Forms.ToolStripMenuItem();
            this.trackTagChange = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.currentSongTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMusicControls.SuspendLayout();
            this.FindAndReplacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).BeginInit();
            this.rightClickMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMusicControls
            // 
            this.panelMusicControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.panelMusicControls.Controls.Add(this.currentSongLabel);
            this.panelMusicControls.Controls.Add(this.endTimeLabel);
            this.panelMusicControls.Controls.Add(this.currentTimeLabel);
            this.panelMusicControls.Controls.Add(this.timeProgressBar);
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
            // currentSongLabel
            // 
            this.currentSongLabel.Location = new System.Drawing.Point(72, 13);
            this.currentSongLabel.Name = "currentSongLabel";
            this.currentSongLabel.Size = new System.Drawing.Size(151, 20);
            this.currentSongLabel.TabIndex = 5;
            this.currentSongLabel.Text = "Select a song to play";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.Location = new System.Drawing.Point(199, 33);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(37, 15);
            this.endTimeLabel.TabIndex = 4;
            this.endTimeLabel.Text = "0:00";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Location = new System.Drawing.Point(65, 33);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(37, 15);
            this.currentTimeLabel.TabIndex = 3;
            this.currentTimeLabel.Text = "0:00";
            // 
            // timeProgressBar
            // 
            this.timeProgressBar.Location = new System.Drawing.Point(100, 33);
            this.timeProgressBar.Name = "timeProgressBar";
            this.timeProgressBar.Size = new System.Drawing.Size(102, 15);
            this.timeProgressBar.Step = 250;
            this.timeProgressBar.TabIndex = 1;
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
            this.toolTip1.SetToolTip(this.buttonSave, "Save Selected Songs into a new folder");
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
            this.toolTip1.SetToolTip(this.buttonForward, "Next Song");
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
            this.buttonPause.Location = new System.Drawing.Point(289, 7);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(35, 37);
            this.buttonPause.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonPause, "Pause Song");
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
            this.toolTip1.SetToolTip(this.buttonBack, "Previous Song");
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
            this.toolTip1.SetToolTip(this.buttonTag, "Find & Replace");
            this.buttonTag.UseVisualStyleBackColor = true;
            this.buttonTag.Click += new System.EventHandler(this.buttonTag_Click);
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
            this.toolTip1.SetToolTip(this.buttonFolder, "Select Songs to load");
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // FindAndReplacePanel
            // 
            this.FindAndReplacePanel.BackColor = System.Drawing.Color.Gray;
            this.FindAndReplacePanel.Controls.Add(this.ReplaceBox);
            this.FindAndReplacePanel.Controls.Add(this.FindBox);
            this.FindAndReplacePanel.Controls.Add(this.ColumnComboBox);
            this.FindAndReplacePanel.Controls.Add(this.collumnComboBoxLabel);
            this.FindAndReplacePanel.Controls.Add(this.findLabel);
            this.FindAndReplacePanel.Controls.Add(this.replaceLabel);
            this.FindAndReplacePanel.Controls.Add(this.ReplaceButton);
            this.FindAndReplacePanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FindAndReplacePanel.Location = new System.Drawing.Point(372, 265);
            this.FindAndReplacePanel.Name = "FindAndReplacePanel";
            this.FindAndReplacePanel.Size = new System.Drawing.Size(229, 83);
            this.FindAndReplacePanel.TabIndex = 3;
            this.FindAndReplacePanel.Visible = false;
            this.FindAndReplacePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FindAndReplacePanel_Paint);
            // 
            // ReplaceBox
            // 
            this.ReplaceBox.BackColor = System.Drawing.SystemColors.Info;
            this.ReplaceBox.Location = new System.Drawing.Point(55, 29);
            this.ReplaceBox.Name = "ReplaceBox";
            this.ReplaceBox.Size = new System.Drawing.Size(166, 23);
            this.ReplaceBox.TabIndex = 6;
            // 
            // FindBox
            // 
            this.FindBox.BackColor = System.Drawing.SystemColors.Info;
            this.FindBox.Location = new System.Drawing.Point(38, 4);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(183, 23);
            this.FindBox.TabIndex = 5;
            // 
            // ColumnComboBox
            // 
            this.ColumnComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.ColumnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnComboBox.FormattingEnabled = true;
            this.ColumnComboBox.Items.AddRange(new object[] {
            "Name",
            "Artist",
            "Track",
            "Album",
            "Genre"});
            this.ColumnComboBox.Location = new System.Drawing.Point(137, 54);
            this.ColumnComboBox.Name = "ColumnComboBox";
            this.ColumnComboBox.Size = new System.Drawing.Size(84, 23);
            this.ColumnComboBox.TabIndex = 4;
            // 
            // collumnComboBoxLabel
            // 
            this.collumnComboBoxLabel.AutoSize = true;
            this.collumnComboBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.collumnComboBoxLabel.Location = new System.Drawing.Point(78, 57);
            this.collumnComboBoxLabel.Name = "collumnComboBoxLabel";
            this.collumnComboBoxLabel.Size = new System.Drawing.Size(53, 15);
            this.collumnComboBoxLabel.TabIndex = 3;
            this.collumnComboBoxLabel.Text = "Column:";
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Location = new System.Drawing.Point(8, 7);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(33, 15);
            this.findLabel.TabIndex = 1;
            this.findLabel.Text = "Find:";
            // 
            // replaceLabel
            // 
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.replaceLabel.Location = new System.Drawing.Point(8, 32);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(51, 15);
            this.replaceLabel.TabIndex = 2;
            this.replaceLabel.Text = "Replace:";
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(8, 53);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(66, 23);
            this.ReplaceButton.TabIndex = 0;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // dataGridViewFileList
            // 
            this.dataGridViewFileList.AllowUserToAddRows = false;
            this.dataGridViewFileList.AllowUserToDeleteRows = false;
            this.dataGridViewFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SequenceColumn,
            this.FileNameColumn,
            this.ArtistColumn,
            this.TrackColumn,
            this.AlbumColumn,
            this.DurationColumn,
            this.GenreColumn,
            this.FilePathColumn,
            this.TrackIDColumn,
            this.DateModifiedColumn});
            this.dataGridViewFileList.Location = new System.Drawing.Point(-4, 48);
            this.dataGridViewFileList.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridViewFileList.Name = "dataGridViewFileList";
            this.dataGridViewFileList.RowHeadersWidth = 20;
            this.dataGridViewFileList.RowTemplate.Height = 29;
            this.dataGridViewFileList.Size = new System.Drawing.Size(606, 300);
            this.dataGridViewFileList.TabIndex = 2;
            this.dataGridViewFileList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFileList_CellMouseDoubleClick);
            this.dataGridViewFileList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFileList_ColumnHeaderMouseClick);
            this.dataGridViewFileList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewFileList_MouseDown);
            // 
            // SequenceColumn
            // 
            this.SequenceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SequenceColumn.HeaderText = "#";
            this.SequenceColumn.Name = "SequenceColumn";
            this.SequenceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SequenceColumn.Width = 39;
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FileNameColumn.HeaderText = "Name";
            this.FileNameColumn.MinimumWidth = 50;
            this.FileNameColumn.Name = "FileNameColumn";
            this.FileNameColumn.ReadOnly = true;
            this.FileNameColumn.Width = 125;
            // 
            // ArtistColumn
            // 
            this.ArtistColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ArtistColumn.HeaderText = "Artist";
            this.ArtistColumn.MinimumWidth = 50;
            this.ArtistColumn.Name = "ArtistColumn";
            this.ArtistColumn.Width = 125;
            // 
            // TrackColumn
            // 
            this.TrackColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TrackColumn.HeaderText = "Track";
            this.TrackColumn.MinimumWidth = 50;
            this.TrackColumn.Name = "TrackColumn";
            this.TrackColumn.Width = 125;
            // 
            // AlbumColumn
            // 
            this.AlbumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AlbumColumn.HeaderText = "Album";
            this.AlbumColumn.MinimumWidth = 50;
            this.AlbumColumn.Name = "AlbumColumn";
            this.AlbumColumn.Width = 150;
            // 
            // DurationColumn
            // 
            this.DurationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DurationColumn.HeaderText = "Duration";
            this.DurationColumn.MinimumWidth = 50;
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.ReadOnly = true;
            this.DurationColumn.Width = 90;
            // 
            // GenreColumn
            // 
            this.GenreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GenreColumn.HeaderText = "Genre";
            this.GenreColumn.Name = "GenreColumn";
            this.GenreColumn.Width = 63;
            // 
            // FilePathColumn
            // 
            this.FilePathColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FilePathColumn.HeaderText = "FilePath";
            this.FilePathColumn.MinimumWidth = 6;
            this.FilePathColumn.Name = "FilePathColumn";
            this.FilePathColumn.ReadOnly = true;
            this.FilePathColumn.Visible = false;
            // 
            // TrackIDColumn
            // 
            this.TrackIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TrackIDColumn.HeaderText = "TrackID";
            this.TrackIDColumn.MinimumWidth = 6;
            this.TrackIDColumn.Name = "TrackIDColumn";
            this.TrackIDColumn.ReadOnly = true;
            this.TrackIDColumn.Visible = false;
            // 
            // DateModifiedColumn
            // 
            this.DateModifiedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateModifiedColumn.HeaderText = "Date Modified";
            this.DateModifiedColumn.MinimumWidth = 50;
            this.DateModifiedColumn.Name = "DateModifiedColumn";
            this.DateModifiedColumn.ReadOnly = true;
            this.DateModifiedColumn.Width = 150;
            // 
            // rightClickMainForm
            // 
            this.rightClickMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playFile,
            this.pauseFile,
            this.ClearTable,
            this.deleteFile,
            this.tagChangeMenu});
            this.rightClickMainForm.Name = "contextMenuStrip1";
            this.rightClickMainForm.Size = new System.Drawing.Size(186, 114);
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
            // ClearTable
            // 
            this.ClearTable.Name = "ClearTable";
            this.ClearTable.Size = new System.Drawing.Size(185, 22);
            this.ClearTable.Text = "Clear Songs";
            this.ClearTable.Click += new System.EventHandler(this.ClearTable_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(185, 22);
            this.deleteFile.Text = "Delete";
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // tagChangeMenu
            // 
            this.tagChangeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumTagChange,
            this.artistTagChange,
            this.commentTagChange,
            this.genreTagChange,
            this.trackTagChange});
            this.tagChangeMenu.Name = "tagChangeMenu";
            this.tagChangeMenu.Size = new System.Drawing.Size(185, 22);
            this.tagChangeMenu.Text = "Change Tags of Song";
            // 
            // albumTagChange
            // 
            this.albumTagChange.Name = "albumTagChange";
            this.albumTagChange.Size = new System.Drawing.Size(149, 22);
            this.albumTagChange.Text = "Album Tag";
            this.albumTagChange.Click += new System.EventHandler(this.albumTagChange_Click);
            // 
            // artistTagChange
            // 
            this.artistTagChange.Name = "artistTagChange";
            this.artistTagChange.Size = new System.Drawing.Size(149, 22);
            this.artistTagChange.Text = "Artist Tag";
            this.artistTagChange.Click += new System.EventHandler(this.artistTagChange_Click);
            // 
            // commentTagChange
            // 
            this.commentTagChange.Name = "commentTagChange";
            this.commentTagChange.Size = new System.Drawing.Size(149, 22);
            this.commentTagChange.Text = "Comment Tag";
            this.commentTagChange.Click += new System.EventHandler(this.commentTagChange_Click);
            // 
            // genreTagChange
            // 
            this.genreTagChange.Name = "genreTagChange";
            this.genreTagChange.Size = new System.Drawing.Size(149, 22);
            this.genreTagChange.Text = "Genre Tag";
            this.genreTagChange.Click += new System.EventHandler(this.genreTagChange_Click);
            // 
            // trackTagChange
            // 
            this.trackTagChange.Name = "trackTagChange";
            this.trackTagChange.Size = new System.Drawing.Size(149, 22);
            this.trackTagChange.Text = "Track Tag";
            this.trackTagChange.Click += new System.EventHandler(this.trackTagChange_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Song";
            this.openFileDialog.Multiselect = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "Album";
            // 
            // currentSongTimer
            // 
            this.currentSongTimer.Interval = 250;
            this.currentSongTimer.Tick += new System.EventHandler(this.currentSongTimer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(602, 347);
            this.ContextMenuStrip = this.rightClickMainForm;
            this.Controls.Add(this.FindAndReplacePanel);
            this.Controls.Add(this.dataGridViewFileList);
            this.Controls.Add(this.panelMusicControls);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.FormMain_Click);
            this.panelMusicControls.ResumeLayout(false);
            this.FindAndReplacePanel.ResumeLayout(false);
            this.FindAndReplacePanel.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem trackTagChange;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem commentTagChange;
        private System.Windows.Forms.ToolStripMenuItem playFile;
        private System.Windows.Forms.ToolStripMenuItem pauseFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem deleteFile;

        private System.Windows.Forms.ToolStripMenuItem ClearTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn SequenceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateModifiedColumn;
        private System.Windows.Forms.Panel FindAndReplacePanel;
        private System.Windows.Forms.TextBox FindBox;
        private System.Windows.Forms.ComboBox ColumnComboBox;
        private System.Windows.Forms.Label collumnComboBoxLabel;
        private System.Windows.Forms.Label replaceLabel;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.TextBox ReplaceBox;
        private System.Windows.Forms.ProgressBar timeProgressBar;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label currentSongLabel;
        private System.Windows.Forms.Timer currentSongTimer;
    }
}

