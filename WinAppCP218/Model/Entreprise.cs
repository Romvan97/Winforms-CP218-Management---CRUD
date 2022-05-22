using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Entreprise
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Postal { get; private set; }
        public string City { get; private set; }
        public string NaceCode { get; private set; }
        public Language Langues { get; private set; }
        public EmployeesNumber CountEmployee { get; private set; }
        public string ErrorMessage { get; private set; }
        public DateTime? SendingCVDate { get; private set; }
        public Entreprise(int pID, string pName, string pAddress, string pPostal, string pCity, string pNaceCode, Language pLanguage, EmployeesNumber pCountEmployee, string pErrorMessage)
        {
            Id = pID;
            Name = pName;
            Address = pAddress;
            Postal = pPostal;
            City = pCity;
            NaceCode = pNaceCode;
            Langues = pLanguage;
            CountEmployee = pCountEmployee;
            ErrorMessage = pErrorMessage;
        }
        public Entreprise(string pLine) // on recoit des lignes
        {

            string[] lineSplit = pLine.Split(';'); // on split avec les points virgules
            this.Id = int.Parse(lineSplit[0]); // on met dans la colonne 0
            this.Name = lineSplit[1];
            this.Address = lineSplit[6];
            this.Postal = lineSplit[7];
            this.City = lineSplit[9];

            try
            {
                this.Langues = (Language)Enum.Parse(typeof(Language), lineSplit[5]);
            }
            catch (ArgumentException)
            {

                this.Langues = Language.Inconnu;
            }

            if (lineSplit[2] != "") 
            {
                this.NaceCode = lineSplit[2];
            }
            else
            {
                this.ErrorMessage += "NaceCode manquant";
            }


            ;
            int CountEmployeeEnum = TranslateStringToInt(lineSplit[4]);
            this.CountEmployee = (EmployeesNumber)CountEmployeeEnum; // cast explicite
            // traduit le texte en un chiffre
        }

        private int TranslateStringToInt(string v)
        {
            // Test de garde
            if (string.IsNullOrEmpty(v)) return 0;
            if (v.IndexOf("-") < 0 && v.IndexOf(">") < 0) throw new ArgumentException("Manque - ou > dans le texte");



            string[] splitted = v.Trim().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries); // trim enleve des esapces devant et derrière
            return int.Parse(splitted[0]);
        }

        public override string ToString() // modifie le bug dans la deuxième forme qui indiquait plusieurs fois BLL.Entreprise
        {
            return $"{this.Postal} {this.Address,-30} {this.Name.Trim(),100}";
        }
    }
}
