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
using BLL.Extensions;

namespace Wui
{
    public partial class FrmEntreprise : Form
    {
        private Entreprise _Entreprise;
        public Entreprise EntrepriseToChange 
        {
            get
            {
                return _Entreprise;
            }

            set
            {
                _Entreprise = value;
               
            }
        
        }


        private void Bind(Entreprise entreprise)
        {
            TxtId.Text = entreprise.Id.ToString();
            TxtAddress.Text = entreprise.Address;
            TxtCity.Text = entreprise.City;
            TxtNaceCode.Text = entreprise.NaceCode?.ToString();
            TxtName.Text = entreprise.Name;
            TxtPostalCode.Text = entreprise.Postal;

            AssignCheckedLanguage(entreprise.Langues);

            CmbEmployeesNumber.Text = entreprise.CountEmployee.ToString();
            CmbEmployeesNumber.SelectedItem = entreprise.CountEmployee.ToString();
        }

        private void AssignCheckedLanguage(Language pLanguage)
        {
            switch (pLanguage)
            {
                case Language.Inconnu:
                    RdbUnknown.Checked = true;
                    break;
                case Language.Duits:
                    RdbDuits.Checked = true;
                    break;
                case Language.Engels:
                    RdbEngels.Checked = true;
                    break;
                case Language.Frans:
                    RdbFrench.Checked = true;
                    break;
                case Language.Nederlands:
                    RdbNederlands.Checked = true;
                    break;
                default:
                    break;
            }
        }

        public FrmEntreprise()
        {
            InitializeComponent();
        }

        private void FrmEntreprise_Load(object sender, EventArgs e)
        {
           
            CmbEmployeesNumber.DataSource = Enum.GetValues(typeof(EmployeesNumber));
            Bind(_Entreprise);
            BtnOk.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAny_TextChanged(object sender, EventArgs e)
        {
            BtnOk.Enabled = true;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            string name = TxtName.Text;
            string address = TxtAddress.Text;
            string postalCode = TxtPostalCode.Text;
            string city = TxtCity.Text;
            string naceCode = TxtNaceCode.Text;
            Language language = ConvertTextToLanguage();

            EmployeesNumber employeesNumber = (EmployeesNumber)CmbEmployeesNumber.SelectedItem;
            string errorMessage = this.EntrepriseToChange.ErrorMessage;
            this.EntrepriseToChange = new Entreprise(id, name, address, postalCode, city, naceCode, language, employeesNumber, errorMessage);
            this.Close();

        }

        private Language ConvertTextToLanguage()
        {
            Language language = Language.Inconnu;

            foreach (Control controle in GrbLangues.Controls)
            {
                RadioButton? myRadioButton = controle as RadioButton;
                if (myRadioButton != null && myRadioButton.Checked)
                {
                   return myRadioButton.Text.ToEnum(Language.Inconnu);
                }
            }

            return language;
        }

        private void CmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnOk.Enabled = true;
        }

        private void CmbEmployeesNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnOk.Enabled = true;
        }

        private void GrbLangues_Enter(object sender, EventArgs e)
        {
            BtnOk.Enabled = true;
        }
    }
}
