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
            this.buttonTrash = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonTag = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.folderSelectDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridViewFileList = new System.Windows.Forms.DataGridView();
            this.ArtistColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMusicControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMusicControls
            // 
            this.panelMusicControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.panelMusicControls.Controls.Add(this.buttonSave);
            this.panelMusicControls.Controls.Add(this.buttonTrash);
            this.panelMusicControls.Controls.Add(this.buttonForward);
            this.panelMusicControls.Controls.Add(this.buttonBack);
            this.panelMusicControls.Controls.Add(this.buttonTag);
            this.panelMusicControls.Controls.Add(this.buttonRename);
            this.panelMusicControls.Controls.Add(this.buttonPause);
            this.panelMusicControls.Controls.Add(this.buttonPlay);
            this.panelMusicControls.Controls.Add(this.buttonFolder);
            this.panelMusicControls.Location = new System.Drawing.Point(-5, 0);
            this.panelMusicControls.Margin = new System.Windows.Forms.Padding(2);
            this.panelMusicControls.Name = "panelMusicControls";
            this.panelMusicControls.Size = new System.Drawing.Size(692, 69);
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
            this.buttonSave.Location = new System.Drawing.Point(568, 14);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(53, 40);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonTrash
            // 
            this.buttonTrash.BackgroundImage = global::MusicManager.Properties.Resources.delete;
            this.buttonTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTrash.FlatAppearance.BorderSize = 0;
            this.buttonTrash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonTrash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrash.Location = new System.Drawing.Point(625, 14);
            this.buttonTrash.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTrash.Name = "buttonTrash";
            this.buttonTrash.Size = new System.Drawing.Size(53, 40);
            this.buttonTrash.TabIndex = 0;
            this.buttonTrash.UseVisualStyleBackColor = true;
            this.buttonTrash.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.BackgroundImage = global::MusicManager.Properties.Resources._038_next_button;
            this.buttonForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonForward.FlatAppearance.BorderSize = 0;
            this.buttonForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForward.Location = new System.Drawing.Point(385, 19);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(2);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(40, 30);
            this.buttonForward.TabIndex = 0;
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::MusicManager.Properties.Resources._036_previous_track;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(274, 20);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 30);
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
            this.buttonTag.Location = new System.Drawing.Point(454, 16);
            this.buttonTag.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTag.Name = "buttonTag";
            this.buttonTag.Size = new System.Drawing.Size(53, 40);
            this.buttonTag.TabIndex = 0;
            this.buttonTag.UseVisualStyleBackColor = true;
            this.buttonTag.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.BackgroundImage = global::MusicManager.Properties.Resources.pencil;
            this.buttonRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRename.FlatAppearance.BorderSize = 0;
            this.buttonRename.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonRename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRename.Location = new System.Drawing.Point(511, 15);
            this.buttonRename.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(53, 40);
            this.buttonRename.TabIndex = 0;
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackgroundImage = global::MusicManager.Properties.Resources._037_pause_button;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Location = new System.Drawing.Point(328, 11);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(40, 50);
            this.buttonPause.TabIndex = 0;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Visible = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = global::MusicManager.Properties.Resources._039_play_button;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Location = new System.Drawing.Point(328, 9);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(40, 50);
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
            this.buttonFolder.Location = new System.Drawing.Point(14, 14);
            this.buttonFolder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(53, 40);
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
            this.ArtistColumn,
            this.TrackColumn,
            this.AlbumColumn,
            this.DurationColumn});
            this.dataGridViewFileList.Location = new System.Drawing.Point(-2, 65);
            this.dataGridViewFileList.Name = "dataGridViewFileList";
            this.dataGridViewFileList.RowHeadersWidth = 51;
            this.dataGridViewFileList.RowTemplate.Height = 29;
            this.dataGridViewFileList.Size = new System.Drawing.Size(689, 396);
            this.dataGridViewFileList.TabIndex = 2;
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
            this.TrackColumn.ReadOnly = true;
            // 
            // AlbumColumn
            // 
            this.AlbumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlbumColumn.HeaderText = "Album";
            this.AlbumColumn.MinimumWidth = 6;
            this.AlbumColumn.Name = "AlbumColumn";
            this.AlbumColumn.ReadOnly = true;
            // 
            // DurationColumn
            // 
            this.DurationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DurationColumn.HeaderText = "Duration";
            this.DurationColumn.MinimumWidth = 6;
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.dataGridViewFileList);
            this.Controls.Add(this.panelMusicControls);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMusicControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMusicControls;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonTrash;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonTag;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.FolderBrowserDialog folderSelectDialogue;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.DataGridView dataGridViewFileList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

