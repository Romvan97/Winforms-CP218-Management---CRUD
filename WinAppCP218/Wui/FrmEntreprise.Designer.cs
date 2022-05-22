namespace Wui
{
    partial class FrmEntreprise
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPostalCode = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbEmployeesNumber = new System.Windows.Forms.ComboBox();
            this.TxtNaceCode = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpSendingCVDate = new System.Windows.Forms.DateTimePicker();
            this.RdbFrench = new System.Windows.Forms.RadioButton();
            this.RdbNederlands = new System.Windows.Forms.RadioButton();
            this.RdbUnknown = new System.Windows.Forms.RadioButton();
            this.RdbEngels = new System.Windows.Forms.RadioButton();
            this.RdbDuits = new System.Windows.Forms.RadioButton();
            this.RdbMale = new System.Windows.Forms.RadioButton();
            this.RdmFemale = new System.Windows.Forms.RadioButton();
            this.RdbAutre = new System.Windows.Forms.RadioButton();
            this.GrbLangues = new System.Windows.Forms.GroupBox();
            this.GrbGenre = new System.Windows.Forms.GroupBox();
            this.GrbLangues.SuspendLayout();
            this.GrbGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(171, 25);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(270, 23);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtAny_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(171, 71);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(270, 23);
            this.TxtAddress.TabIndex = 3;
            this.TxtAddress.TextChanged += new System.EventHandler(this.TxtAny_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "NaceCode";
            // 
            // TxtPostalCode
            // 
            this.TxtPostalCode.Location = new System.Drawing.Point(171, 112);
            this.TxtPostalCode.Name = "TxtPostalCode";
            this.TxtPostalCode.Size = new System.Drawing.Size(59, 23);
            this.TxtPostalCode.TabIndex = 7;
            this.TxtPostalCode.TextChanged += new System.EventHandler(this.TxtAny_TextChanged);
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(247, 112);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(194, 23);
            this.TxtCity.TabIndex = 8;
            this.TxtCity.TextChanged += new System.EventHandler(this.TxtAny_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Taille ";
            // 
            // CmbEmployeesNumber
            // 
            this.CmbEmployeesNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmployeesNumber.FormattingEnabled = true;
            this.CmbEmployeesNumber.Location = new System.Drawing.Point(171, 233);
            this.CmbEmployeesNumber.Name = "CmbEmployeesNumber";
            this.CmbEmployeesNumber.Size = new System.Drawing.Size(186, 23);
            this.CmbEmployeesNumber.TabIndex = 12;
            this.CmbEmployeesNumber.SelectedIndexChanged += new System.EventHandler(this.CmbEmployeesNumber_SelectedIndexChanged);
            // 
            // TxtNaceCode
            // 
            this.TxtNaceCode.Location = new System.Drawing.Point(171, 152);
            this.TxtNaceCode.Name = "TxtNaceCode";
            this.TxtNaceCode.Size = new System.Drawing.Size(100, 23);
            this.TxtNaceCode.TabIndex = 13;
            this.TxtNaceCode.TextChanged += new System.EventHandler(this.TxtAny_TextChanged);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(125, 333);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(86, 38);
            this.BtnOk.TabIndex = 14;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(295, 333);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 38);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(440, 348);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(100, 23);
            this.TxtId.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date d\'envoi du cv";
            // 
            // DtpSendingCVDate
            // 
            this.DtpSendingCVDate.Location = new System.Drawing.Point(171, 190);
            this.DtpSendingCVDate.Name = "DtpSendingCVDate";
            this.DtpSendingCVDate.Size = new System.Drawing.Size(200, 23);
            this.DtpSendingCVDate.TabIndex = 18;
            // 
            // RdbFrench
            // 
            this.RdbFrench.AutoSize = true;
            this.RdbFrench.Location = new System.Drawing.Point(16, 55);
            this.RdbFrench.Name = "RdbFrench";
            this.RdbFrench.Size = new System.Drawing.Size(53, 19);
            this.RdbFrench.TabIndex = 19;
            this.RdbFrench.TabStop = true;
            this.RdbFrench.Text = "Frans";
            this.RdbFrench.UseVisualStyleBackColor = true;
            // 
            // RdbNederlands
            // 
            this.RdbNederlands.AutoSize = true;
            this.RdbNederlands.Location = new System.Drawing.Point(16, 86);
            this.RdbNederlands.Name = "RdbNederlands";
            this.RdbNederlands.Size = new System.Drawing.Size(85, 19);
            this.RdbNederlands.TabIndex = 20;
            this.RdbNederlands.TabStop = true;
            this.RdbNederlands.Text = "Nederlands";
            this.RdbNederlands.UseVisualStyleBackColor = true;
            // 
            // RdbUnknown
            // 
            this.RdbUnknown.AutoSize = true;
            this.RdbUnknown.Location = new System.Drawing.Point(16, 24);
            this.RdbUnknown.Name = "RdbUnknown";
            this.RdbUnknown.Size = new System.Drawing.Size(69, 19);
            this.RdbUnknown.TabIndex = 21;
            this.RdbUnknown.TabStop = true;
            this.RdbUnknown.Text = "Inconnu";
            this.RdbUnknown.UseVisualStyleBackColor = true;
            // 
            // RdbEngels
            // 
            this.RdbEngels.AutoSize = true;
            this.RdbEngels.Location = new System.Drawing.Point(16, 117);
            this.RdbEngels.Name = "RdbEngels";
            this.RdbEngels.Size = new System.Drawing.Size(59, 19);
            this.RdbEngels.TabIndex = 22;
            this.RdbEngels.TabStop = true;
            this.RdbEngels.Text = "Engels";
            this.RdbEngels.UseVisualStyleBackColor = true;
            // 
            // RdbDuits
            // 
            this.RdbDuits.AutoSize = true;
            this.RdbDuits.Location = new System.Drawing.Point(16, 148);
            this.RdbDuits.Name = "RdbDuits";
            this.RdbDuits.Size = new System.Drawing.Size(52, 19);
            this.RdbDuits.TabIndex = 23;
            this.RdbDuits.TabStop = true;
            this.RdbDuits.Text = "Duits";
            this.RdbDuits.UseVisualStyleBackColor = true;
            // 
            // RdbMale
            // 
            this.RdbMale.AutoSize = true;
            this.RdbMale.Location = new System.Drawing.Point(16, 22);
            this.RdbMale.Name = "RdbMale";
            this.RdbMale.Size = new System.Drawing.Size(73, 19);
            this.RdbMale.TabIndex = 25;
            this.RdbMale.TabStop = true;
            this.RdbMale.Text = "Masculin";
            this.RdbMale.UseVisualStyleBackColor = true;
            // 
            // RdmFemale
            // 
            this.RdmFemale.AutoSize = true;
            this.RdmFemale.Location = new System.Drawing.Point(16, 53);
            this.RdmFemale.Name = "RdmFemale";
            this.RdmFemale.Size = new System.Drawing.Size(68, 19);
            this.RdmFemale.TabIndex = 26;
            this.RdmFemale.TabStop = true;
            this.RdmFemale.Text = "Féminin";
            this.RdmFemale.UseVisualStyleBackColor = true;
            // 
            // RdbAutre
            // 
            this.RdbAutre.AutoSize = true;
            this.RdbAutre.Checked = true;
            this.RdbAutre.Location = new System.Drawing.Point(16, 84);
            this.RdbAutre.Name = "RdbAutre";
            this.RdbAutre.Size = new System.Drawing.Size(54, 19);
            this.RdbAutre.TabIndex = 27;
            this.RdbAutre.TabStop = true;
            this.RdbAutre.Text = "Autre";
            this.RdbAutre.UseVisualStyleBackColor = true;
            // 
            // GrbLangues
            // 
            this.GrbLangues.Controls.Add(this.RdbUnknown);
            this.GrbLangues.Controls.Add(this.RdbFrench);
            this.GrbLangues.Controls.Add(this.RdbNederlands);
            this.GrbLangues.Controls.Add(this.RdbEngels);
            this.GrbLangues.Controls.Add(this.RdbDuits);
            this.GrbLangues.Location = new System.Drawing.Point(461, 17);
            this.GrbLangues.Name = "GrbLangues";
            this.GrbLangues.Size = new System.Drawing.Size(106, 175);
            this.GrbLangues.TabIndex = 28;
            this.GrbLangues.TabStop = false;
            this.GrbLangues.Text = "Langues";
            this.GrbLangues.Enter += new System.EventHandler(this.GrbLangues_Enter);
            // 
            // GrbGenre
            // 
            this.GrbGenre.Controls.Add(this.RdmFemale);
            this.GrbGenre.Controls.Add(this.RdbMale);
            this.GrbGenre.Controls.Add(this.RdbAutre);
            this.GrbGenre.Location = new System.Drawing.Point(461, 211);
            this.GrbGenre.Name = "GrbGenre";
            this.GrbGenre.Size = new System.Drawing.Size(106, 109);
            this.GrbGenre.TabIndex = 29;
            this.GrbGenre.TabStop = false;
            this.GrbGenre.Text = "Genre";
            // 
            // FrmEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 395);
            this.Controls.Add(this.GrbGenre);
            this.Controls.Add(this.GrbLangues);
            this.Controls.Add(this.DtpSendingCVDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TxtNaceCode);
            this.Controls.Add(this.CmbEmployeesNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtPostalCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Name = "FrmEntreprise";
            this.Text = "Fiche signalétique d\'entreprise";
            this.Load += new System.EventHandler(this.FrmEntreprise_Load);
            this.GrbLangues.ResumeLayout(false);
            this.GrbLangues.PerformLayout();
            this.GrbGenre.ResumeLayout(false);
            this.GrbGenre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtName;
        private Label label2;
        private TextBox TxtAddress;
        private Label label3;
        private Label label4;
        private TextBox TxtPostalCode;
        private TextBox TxtCity;
        private Label label6;
        private ComboBox CmbEmployeesNumber;
        private TextBox TxtNaceCode;
        private Button BtnOk;
        private Button BtnCancel;
        private TextBox TxtId;
        private Label label7;
        private DateTimePicker DtpSendingCVDate;
        private RadioButton RdbFrench;
        private RadioButton RdbNederlands;
        private RadioButton RdbUnknown;
        private RadioButton RdbEngels;
        private RadioButton RdbDuits;
        private RadioButton RdbMale;
        private RadioButton RdmFemale;
        private RadioButton RdbAutre;
        private GroupBox GrbLangues;
        private GroupBox GrbGenre;
    }
}