
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
            this.FindBox = new System.Windows.Forms.TextBox();
            this.ColumnComboBox = new System.Windows.Forms.ComboBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.ReplaceLabel = new System.Windows.Forms.Label();
            this.ReplaceBox = new System.Windows.Forms.TextBox();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RemoveButton.Location = new System.Drawing.Point(12, 66);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(81, 23);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Replace";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // FindBox
            // 
            this.FindBox.BackColor = System.Drawing.SystemColors.Info;
            this.FindBox.Location = new System.Drawing.Point(68, 12);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(205, 23);
            this.FindBox.TabIndex = 1;
            // 
            // ColumnComboBox
            // 
            this.ColumnComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ColumnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnComboBox.FormattingEnabled = true;
            this.ColumnComboBox.Items.AddRange(new object[] {
            "Name",
            "Artist",
            "Track",
            "Album",
            "Genre"});
            this.ColumnComboBox.Location = new System.Drawing.Point(155, 66);
            this.ColumnComboBox.Name = "ColumnComboBox";
            this.ColumnComboBox.Size = new System.Drawing.Size(118, 23);
            this.ColumnComboBox.TabIndex = 3;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(32, 15);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 15);
            this.FindLabel.TabIndex = 3;
            this.FindLabel.Text = "Find";
            // 
            // ReplaceLabel
            // 
            this.ReplaceLabel.AutoSize = true;
            this.ReplaceLabel.Location = new System.Drawing.Point(14, 40);
            this.ReplaceLabel.Name = "ReplaceLabel";
            this.ReplaceLabel.Size = new System.Drawing.Size(48, 15);
            this.ReplaceLabel.TabIndex = 4;
            this.ReplaceLabel.Text = "Replace";
            // 
            // ReplaceBox
            // 
            this.ReplaceBox.BackColor = System.Drawing.SystemColors.Info;
            this.ReplaceBox.Location = new System.Drawing.Point(68, 37);
            this.ReplaceBox.Name = "ReplaceBox";
            this.ReplaceBox.Size = new System.Drawing.Size(205, 23);
            this.ReplaceBox.TabIndex = 2;
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Location = new System.Drawing.Point(99, 70);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(50, 15);
            this.ColumnLabel.TabIndex = 6;
            this.ColumnLabel.Text = "Column";
            // 
            // RemoveText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(288, 106);
            this.Controls.Add(this.ColumnLabel);
            this.Controls.Add(this.ReplaceBox);
            this.Controls.Add(this.ReplaceLabel);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this.ColumnComboBox);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.RemoveButton);
            this.Name = "RemoveText";
            this.Text = "ReplaceText";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemoveText_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        public System.Windows.Forms.TextBox FindBox;
        private System.Windows.Forms.ComboBox ColumnComboBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Label ReplaceLabel;
        private System.Windows.Forms.TextBox ReplaceBox;
        private System.Windows.Forms.Label ColumnLabel;
    }
}