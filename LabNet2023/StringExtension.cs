using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023
{
    public static class StringExtension
    {
        public static string PrimeraMayuscula(this string fraseInicial)
        {
            char primeraLetra = char.ToUpper(fraseInicial[0]);
            string restoDeFrase = fraseInicial.Substring(1);

            return primeraLetra + restoDeFrase;
        }
    }
}
