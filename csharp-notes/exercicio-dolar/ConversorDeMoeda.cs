using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_dolar
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0;
       

        public static double Dolar(double compra, double cotacao)
        {
            double total = compra * cotacao;
            double imposto = total / 100.0 * IOF;
            return total + imposto ;
        }


    }
}
