﻿namespace deskdecorator
{
    partial class Form1
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            TransparencyKey = Color.Black;
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private NoteBox noteBox1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
