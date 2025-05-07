using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_funcionarios
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquid()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double aumento)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * aumento / 100.0);
        }

        public override string ToString()
        {
            return Nome + ", $" + SalarioLiquid().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
