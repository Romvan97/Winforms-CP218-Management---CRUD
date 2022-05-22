using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wui
{
    public partial class FrmFile : Form
    {
        public IList<Entreprise> FileEntreprises { get; private set; }
        public FrmFile()
        {
            InitializeComponent();
        }

        private void FrmFile_Load(object sender, EventArgs e)
        {

        }

        private void BtnGetFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "csv files |*.csv";
                openFileDialog.Title = "Lire fichier csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    this.FileEntreprises = Cp218.GetEntrepriseData(fileName);
                    
                    LstLines.DataSource = FileEntreprises;
                }
            }

        }
    }
}
