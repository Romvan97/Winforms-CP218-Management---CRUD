using BLL;
using Model;
using System.Diagnostics;

namespace Wui
{
    public partial class FrmMain : Form
    {
        private IList<Entreprise> _items = new List<Entreprise>(); //permet de sauver le texte et l'utiliser partout dans le main
        private IList<Entreprise> _LanguesItems = new List<Entreprise>();
        private IList<Entreprise> _CountItems = new List<Entreprise>();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            toolStripStatusLabelDate.Text = DateTime.Today.ToLongDateString();

        }

        private void lireFichierCP218ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //using (FrmFile frmFile = new FrmFile())
            //{
            //    frmFile.ShowDialog();
            //    _items = frmFile.FileEntreprises;
            //    DgvFileLines.DataSource = _items;
            //}
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "csv files |*.csv";
                openFileDialog.Title = "Lire fichier csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    this.Cursor = Cursors.WaitCursor;


                    _items = Cp218.GetEntrepriseData(fileName);
                    DgvFileLines.DataSource = _items;
                    this.Cursor = Cursors.Default;
                    // this.FileEntreprises = Cp218.GetEntrepriseData(fileName);

                    // LstLines.DataSource = FileEntreprises;
                }
            }
        }

        private void DgvFileLines_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            using (FrmEntreprise myFrm = new FrmEntreprise())
            {

                myFrm.EntrepriseToChange = _items[e.RowIndex];
                myFrm.ShowDialog();
                _items[e.RowIndex] = myFrm.EntrepriseToChange;
                DgvFileLines.Refresh();


            }


        }

        private void TbcMain_Click(object sender, EventArgs e)
        {
            string tabPageCurrent = TbcMain.SelectedTab.Name;
            switch (tabPageCurrent)
            {
                case "TbpAllEntreprises":
                    DgvFileLines.Refresh();
                    break;

                case "TbpMissingLanguages":
                    LoadTbpMissingLanguage();

                    break;

                case "TbpMissingSize":
                    LoadTbpMissingSize();

                    break;

                default: MessageBox.Show($"Tab page inconnu {tabPageCurrent}"); break;

            }
        }

        private void LoadTbpMissingSize()
        {

            this.Cursor = Cursors.WaitCursor;
            _CountItems = _items
                                            .Where(ent => ent.CountEmployee == EmployeesNumber.Inconnu)
                                            .OrderBy(e => e.Name)
                                            .ThenBy(e => e.Postal)
                                            .ToList();
            DgvMissingSize.DataSource = _CountItems;
            this.Cursor = Cursors.Default;
            DgvMissingSize.Refresh();
        }

        private void LoadTbpMissingLanguage()
        {
            this.Cursor = Cursors.WaitCursor;
            _LanguesItems = _items
                                                .Where(ent => ent.Langues == Language.Inconnu)
                                                .OrderBy(e => e.Name)
                                                .ThenBy(e => e.Postal)
                                                .ToList();
            DgvMissingLanguage.DataSource = _LanguesItems;
            this.Cursor = Cursors.Default;
        }

        private void DgvMissingLanguage_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (FrmEntreprise myFrm = new FrmEntreprise())
            {

                myFrm.EntrepriseToChange = _LanguesItems[e.RowIndex];
                myFrm.ShowDialog();
                _LanguesItems[e.RowIndex] = myFrm.EntrepriseToChange;

                UpdateMissingforSelectedListAll(myFrm, ChangeType.Language);

                DgvMissingLanguage.Refresh();

            }

        }


        private void DgvMissingSize_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (FrmEntreprise myFrm = new FrmEntreprise())
            {

                myFrm.EntrepriseToChange = _CountItems[e.RowIndex];
                myFrm.ShowDialog();

                _CountItems[e.RowIndex] = myFrm.EntrepriseToChange;

                UpdateMissingforSelectedListAll(myFrm, ChangeType.Quantity);

                DgvMissingSize.Refresh();

            }
        }
        /// <summary>
        /// Cette méthode met à jour l'entreprise modifée dans la grille missing.
        /// Attention !! Ne fonctionne pas avec un foreach
        /// </summary>
        /// <param name="myFrmLangue"></param>
        private void UpdateMissingforSelectedListAll(FrmEntreprise myFrm, ChangeType pType)
        {
            int current = 0;
            bool isFound = false; 
            for (; current < _items.Count && !isFound; current++)
            {

                switch (pType)
                {
                    case ChangeType.Language:

                        if (_items[current].Id == myFrm.EntrepriseToChange.Id && _items[current].Langues == Language.Inconnu)

                        {
                            _items[current] = myFrm.EntrepriseToChange;
                            isFound = true;
                        }

                        break;

                    case ChangeType.Quantity:

                            if (_items[current].Id == myFrm.EntrepriseToChange.Id && _items[current].CountEmployee == EmployeesNumber.Inconnu)
                            {
                                _items[current] = myFrm.EntrepriseToChange;
                                isFound = true;
                            }


                        break;
                    default:
                        break;
                }

            }
            Debug.WriteLine(current); // permet de voir combient de fois il a bouclé
        }
    }
}