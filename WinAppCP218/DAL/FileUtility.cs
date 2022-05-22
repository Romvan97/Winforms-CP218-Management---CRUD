using Model;
using System.Text;

namespace DAL
{
    public class FileUtility
    {

        public static IList<string> ReadFileCp218(string pFileName)
        {

            string[] lines = File.ReadAllLines(pFileName,Encoding.UTF7);

            return lines;

        }

        public static IList<Entreprise> ReadEntrepriseFromFileCp218(string pFileName)
        {

            string[] lines = File.ReadAllLines(pFileName, Encoding.UTF7);
            IList<Entreprise> entreprises = new List<Entreprise>();

            foreach (var item in lines.Skip(1)) //passer le premier avec linq ! use system linq
            {
                Entreprise myEntreprise = new Entreprise(item);
                entreprises.Add(myEntreprise);
            }


            return entreprises;

        }


    }
}