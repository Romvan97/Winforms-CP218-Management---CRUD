using DAL;
using Model;
using System.Linq;

namespace BLL
{
    public static class Cp218
    {

        public static IList<Entreprise> GetEntrepriseData(string pPath)
        {
            return FileUtility.ReadEntrepriseFromFileCp218(pPath).OrderBy(entrep => entrep.Name).ToList();
        }

    }
}