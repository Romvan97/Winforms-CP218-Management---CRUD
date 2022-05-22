namespace Wui
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lireFichierCP218ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lireExcelCP218ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.DgvFileLines = new System.Windows.Forms.DataGridView();
            this.TbcMain = new System.Windows.Forms.TabControl();
            this.TbpAllEntreprises = new System.Windows.Forms.TabPage();
            this.TbpMissingLanguages = new System.Windows.Forms.TabPage();
            this.DgvMissingLanguage = new System.Windows.Forms.DataGridView();
            this.TbpMissingSize = new System.Windows.Forms.TabPage();
            this.DgvMissingSize = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFileLines)).BeginInit();
            this.TbcMain.SuspendLayout();
            this.TbpAllEntreprises.SuspendLayout();
            this.TbpMissingLanguages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMissingLanguage)).BeginInit();
            this.TbpMissingSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMissingSize)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.affichageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lireFichierCP218ToolStripMenuItem,
            this.lireExcelCP218ToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // lireFichierCP218ToolStripMenuItem
            // 
            this.lireFichierCP218ToolStripMenuItem.Name = "lireFichierCP218ToolStripMenuItem";
            this.lireFichierCP218ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.lireFichierCP218ToolStripMenuItem.Text = "Lire fichier CP218";
            this.lireFichierCP218ToolStripMenuItem.Click += new System.EventHandler(this.lireFichierCP218ToolStripMenuItem_Click);
            // 
            // lireExcelCP218ToolStripMenuItem
            // 
            this.lireExcelCP218ToolStripMenuItem.Name = "lireExcelCP218ToolStripMenuItem";
            this.lireExcelCP218ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.lireExcelCP218ToolStripMenuItem.Text = "Lire Excel CP218";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabelDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(767, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(250, 16);
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.AutoSize = false;
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(200, 17);
            // 
            // DgvFileLines
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.DgvFileLines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvFileLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFileLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvFileLines.Location = new System.Drawing.Point(3, 3);
            this.DgvFileLines.Name = "DgvFileLines";
            this.DgvFileLines.RowTemplate.Height = 25;
            this.DgvFileLines.Size = new System.Drawing.Size(753, 425);
            this.DgvFileLines.TabIndex = 2;
            this.DgvFileLines.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvFileLines_RowHeaderMouseDoubleClick);
            // 
            // TbcMain
            // 
            this.TbcMain.Controls.Add(this.TbpAllEntreprises);
            this.TbcMain.Controls.Add(this.TbpMissingLanguages);
            this.TbcMain.Controls.Add(this.TbpMissingSize);
            this.TbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcMain.Location = new System.Drawing.Point(0, 24);
            this.TbcMain.Name = "TbcMain";
            this.TbcMain.SelectedIndex = 0;
            this.TbcMain.Size = new System.Drawing.Size(767, 459);
            this.TbcMain.TabIndex = 3;
            this.TbcMain.Click += new System.EventHandler(this.TbcMain_Click);
            // 
            // TbpAllEntreprises
            // 
            this.TbpAllEntreprises.Controls.Add(this.DgvFileLines);
            this.TbpAllEntreprises.Location = new System.Drawing.Point(4, 24);
            this.TbpAllEntreprises.Name = "TbpAllEntreprises";
            this.TbpAllEntreprises.Padding = new System.Windows.Forms.Padding(3);
            this.TbpAllEntreprises.Size = new System.Drawing.Size(759, 431);
            this.TbpAllEntreprises.TabIndex = 0;
            this.TbpAllEntreprises.Text = "Liste des entreprises";
            this.TbpAllEntreprises.UseVisualStyleBackColor = true;
            // 
            // TbpMissingLanguages
            // 
            this.TbpMissingLanguages.Controls.Add(this.DgvMissingLanguage);
            this.TbpMissingLanguages.Location = new System.Drawing.Point(4, 24);
            this.TbpMissingLanguages.Name = "TbpMissingLanguages";
            this.TbpMissingLanguages.Padding = new System.Windows.Forms.Padding(3);
            this.TbpMissingLanguages.Size = new System.Drawing.Size(759, 431);
            this.TbpMissingLanguages.TabIndex = 1;
            this.TbpMissingLanguages.Text = "Liste langues manquantes";
            this.TbpMissingLanguages.UseVisualStyleBackColor = true;
            // 
            // DgvMissingLanguage
            // 
            this.DgvMissingLanguage.AllowUserToAddRows = false;
            this.DgvMissingLanguage.AllowUserToDeleteRows = false;
            this.DgvMissingLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMissingLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMissingLanguage.Location = new System.Drawing.Point(3, 3);
            this.DgvMissingLanguage.Name = "DgvMissingLanguage";
            this.DgvMissingLanguage.RowTemplate.Height = 25;
            this.DgvMissingLanguage.Size = new System.Drawing.Size(753, 425);
            this.DgvMissingLanguage.TabIndex = 0;
            this.DgvMissingLanguage.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMissingLanguage_RowHeaderMouseDoubleClick);
            // 
            // TbpMissingSize
            // 
            this.TbpMissingSize.Controls.Add(this.DgvMissingSize);
            this.TbpMissingSize.Location = new System.Drawing.Point(4, 24);
            this.TbpMissingSize.Name = "TbpMissingSize";
            this.TbpMissingSize.Size = new System.Drawing.Size(759, 431);
            this.TbpMissingSize.TabIndex = 2;
            this.TbpMissingSize.Text = "Liste taille manquante";
            this.TbpMissingSize.UseVisualStyleBackColor = true;
            // 
            // DgvMissingSize
            // 
            this.DgvMissingSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMissingSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMissingSize.Location = new System.Drawing.Point(0, 0);
            this.DgvMissingSize.Name = "DgvMissingSize";
            this.DgvMissingSize.RowTemplate.Height = 25;
            this.DgvMissingSize.Size = new System.Drawing.Size(759, 431);
            this.DgvMissingSize.TabIndex = 0;
            this.DgvMissingSize.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMissingSize_RowHeaderMouseDoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 505);
            this.Controls.Add(this.TbcMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Gestion des entreprises de la CP218";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFileLines)).EndInit();
            this.TbcMain.ResumeLayout(false);
            this.TbpAllEntreprises.ResumeLayout(false);
            this.TbpMissingLanguages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMissingLanguage)).EndInit();
            this.TbpMissingSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMissingSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem lireFichierCP218ToolStripMenuItem;
        private ToolStripMenuItem lireExcelCP218ToolStripMenuItem;
        private ToolStripMenuItem editionToolStripMenuItem;
        private ToolStripMenuItem affichageToolStripMenuItem;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabelDate;
        private DataGridView DgvFileLines;
        private TabControl TbcMain;
        private TabPage TbpAllEntreprises;
        private TabPage TbpMissingLanguages;
        private TabPage TbpMissingSize;
        private DataGridView DgvMissingLanguage;
        private DataGridView DgvMissingSize;
    }
}