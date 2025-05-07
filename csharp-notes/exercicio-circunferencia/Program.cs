using System;
using System.Globalization;

namespace exercicio_circunferencia
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.Write("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }


    }
}