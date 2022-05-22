using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Extensions
{
    public static class ExtensionUtility // pour les extensions, static obligatoirement
    {
        public static T ToEnum<T>(this String pText, T pDefaultValue) where T : struct
        {
           
            if (string.IsNullOrEmpty(pText))
            {
                return pDefaultValue;
            }
            T result;
            return Enum.TryParse<T>(pText, true, out result) ? result : pDefaultValue;
        }
        public static bool IsEven(this int pValue)
        {
            return pValue % 2 == 0;
        }

    }
}
