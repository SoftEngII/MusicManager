﻿
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
            this.panelMusicControls = new System.Windows.Forms.Panel();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonTrash = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.panelFileControls = new System.Windows.Forms.Panel();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonTag = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelMusicControls.SuspendLayout();
            this.panelFileControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMusicControls
            // 
            this.panelMusicControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.panelMusicControls.Controls.Add(this.buttonForward);
            this.panelMusicControls.Controls.Add(this.buttonBack);
            this.panelMusicControls.Controls.Add(this.buttonPause);
            this.panelMusicControls.Controls.Add(this.buttonPlay);
            this.panelMusicControls.Location = new System.Drawing.Point(116, 0);
            this.panelMusicControls.Name = "panelMusicControls";
            this.panelMusicControls.Size = new System.Drawing.Size(685, 62);
            this.panelMusicControls.TabIndex = 0;
            // 
            // buttonForward
            // 
            this.buttonForward.BackgroundImage = global::MusicManager.Properties.Resources._038_next_button;
            this.buttonForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonForward.FlatAppearance.BorderSize = 0;
            this.buttonForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForward.Location = new System.Drawing.Point(306, 12);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(50, 38);
            this.buttonForward.TabIndex = 0;
            this.buttonForward.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::MusicManager.Properties.Resources._036_previous_track;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(194, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(50, 38);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonPause
            // 
            this.buttonPause.BackgroundImage = global::MusicManager.Properties.Resources._037_pause_button;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Location = new System.Drawing.Point(250, 0);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(50, 62);
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
            this.buttonPlay.Location = new System.Drawing.Point(250, 0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(50, 62);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonTrash
            // 
            this.buttonTrash.BackgroundImage = global::MusicManager.Properties.Resources.delete;
            this.buttonTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTrash.FlatAppearance.BorderSize = 0;
            this.buttonTrash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonTrash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrash.Location = new System.Drawing.Point(28, 84);
            this.buttonTrash.Name = "buttonTrash";
            this.buttonTrash.Size = new System.Drawing.Size(65, 50);
            this.buttonTrash.TabIndex = 0;
            this.buttonTrash.UseVisualStyleBackColor = true;
            this.buttonTrash.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonFolder
            // 
            this.buttonFolder.BackgroundImage = global::MusicManager.Properties.Resources.folder;
            this.buttonFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFolder.FlatAppearance.BorderSize = 0;
            this.buttonFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFolder.Location = new System.Drawing.Point(28, 12);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(65, 50);
            this.buttonFolder.TabIndex = 0;
            this.buttonFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // panelFileControls
            // 
            this.panelFileControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.panelFileControls.Controls.Add(this.buttonSort);
            this.panelFileControls.Controls.Add(this.buttonTag);
            this.panelFileControls.Controls.Add(this.buttonRename);
            this.panelFileControls.Controls.Add(this.buttonSave);
            this.panelFileControls.Controls.Add(this.buttonTrash);
            this.panelFileControls.Controls.Add(this.buttonFolder);
            this.panelFileControls.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panelFileControls.Location = new System.Drawing.Point(-5, 0);
            this.panelFileControls.Name = "panelFileControls";
            this.panelFileControls.Size = new System.Drawing.Size(121, 457);
            this.panelFileControls.TabIndex = 1;
            // 
            // buttonSort
            // 
            this.buttonSort.BackgroundImage = global::MusicManager.Properties.Resources.sort;
            this.buttonSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSort.FlatAppearance.BorderSize = 0;
            this.buttonSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Location = new System.Drawing.Point(28, 388);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(65, 50);
            this.buttonSort.TabIndex = 0;
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonTag
            // 
            this.buttonTag.BackgroundImage = global::MusicManager.Properties.Resources.supermarket;
            this.buttonTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTag.FlatAppearance.BorderSize = 0;
            this.buttonTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTag.Location = new System.Drawing.Point(28, 314);
            this.buttonTag.Name = "buttonTag";
            this.buttonTag.Size = new System.Drawing.Size(65, 50);
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
            this.buttonRename.Location = new System.Drawing.Point(28, 237);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(65, 50);
            this.buttonRename.TabIndex = 0;
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = global::MusicManager.Properties.Resources.floppy_disk;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(28, 160);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(65, 50);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFileControls);
            this.Controls.Add(this.panelMusicControls);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMusicControls.ResumeLayout(false);
            this.panelFileControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMusicControls;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonTrash;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Panel panelFileControls;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonTag;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonSort;
    }
}

