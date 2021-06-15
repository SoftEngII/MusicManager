
namespace MusicManager
{
    partial class RemoveText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RemoveBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RemoveButton.Location = new System.Drawing.Point(12, 41);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(81, 23);
            this.RemoveButton.TabIndex = 0;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveBox
            // 
            this.RemoveBox.BackColor = System.Drawing.SystemColors.Info;
            this.RemoveBox.Location = new System.Drawing.Point(12, 12);
            this.RemoveBox.Name = "RemoveBox";
            this.RemoveBox.Size = new System.Drawing.Size(205, 23);
            this.RemoveBox.TabIndex = 1;
            // 
            // RemoveText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(240, 93);
            this.Controls.Add(this.RemoveBox);
            this.Controls.Add(this.RemoveButton);
            this.Name = "RemoveText";
            this.Text = "RemoveText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        public System.Windows.Forms.TextBox RemoveBox;
    }
}