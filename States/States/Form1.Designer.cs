﻿namespace States
{
    partial class Form1
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
            this.statesComboBox = new System.Windows.Forms.ComboBox();
            this.statesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // statesComboBox
            // 
            this.statesComboBox.AccessibleName = "";
            this.statesComboBox.FormattingEnabled = true;
            this.statesComboBox.Location = new System.Drawing.Point(13, 13);
            this.statesComboBox.Name = "statesComboBox";
            this.statesComboBox.Size = new System.Drawing.Size(121, 21);
            this.statesComboBox.TabIndex = 0;
            this.statesComboBox.SelectedIndexChanged += new System.EventHandler(this.statesComboBox_SelectedIndexChanged);
            // 
            // statesListBox
            // 
            this.statesListBox.FormattingEnabled = true;
            this.statesListBox.Location = new System.Drawing.Point(13, 80);
            this.statesListBox.Name = "statesListBox";
            this.statesListBox.Size = new System.Drawing.Size(120, 95);
            this.statesListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.statesListBox);
            this.Controls.Add(this.statesComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox statesComboBox;
        private System.Windows.Forms.ListBox statesListBox;
    }
}

