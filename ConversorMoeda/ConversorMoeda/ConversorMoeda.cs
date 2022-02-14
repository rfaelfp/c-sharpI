using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeda
{
    internal class ConversorMoeda
    {
        public static  double Converter(double quantidadeDolar, double cotacaoDolar)
        {
            return (quantidadeDolar * cotacaoDolar) + ((quantidadeDolar / 100) * 6);
        }

    }
}
