namespace Wui
{
    partial class FrmFile
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
            this.BtnGetFile = new System.Windows.Forms.Button();
            this.LstLines = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnGetFile
            // 
            this.BtnGetFile.Location = new System.Drawing.Point(201, 39);
            this.BtnGetFile.Name = "BtnGetFile";
            this.BtnGetFile.Size = new System.Drawing.Size(111, 23);
            this.BtnGetFile.TabIndex = 0;
            this.BtnGetFile.Text = "Lire le fichier";
            this.BtnGetFile.UseVisualStyleBackColor = true;
            this.BtnGetFile.Click += new System.EventHandler(this.BtnGetFile_Click);
            // 
            // LstLines
            // 
            this.LstLines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LstLines.FormattingEnabled = true;
            this.LstLines.ItemHeight = 15;
            this.LstLines.Location = new System.Drawing.Point(0, 86);
            this.LstLines.Name = "LstLines";
            this.LstLines.ScrollAlwaysVisible = true;
            this.LstLines.Size = new System.Drawing.Size(800, 364);
            this.LstLines.TabIndex = 1;
            // 
            // FrmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstLines);
            this.Controls.Add(this.BtnGetFile);
            this.Name = "FrmFile";
            this.Text = "FrmFile";
            this.Load += new System.EventHandler(this.FrmFile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnGetFile;
        private ListBox LstLines;
    }
}