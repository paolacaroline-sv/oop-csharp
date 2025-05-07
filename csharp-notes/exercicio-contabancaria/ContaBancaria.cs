using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_contabancaria
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
          
        public ContaBancaria(int numero, string nome, double saldo)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }
      
        public void Depositar (double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double saque)
        {
            Saldo -= (saque + 5);
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", " +
                "Titular: " + Nome + ", " +
                "Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
