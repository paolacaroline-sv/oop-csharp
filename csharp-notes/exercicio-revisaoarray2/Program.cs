using System;
using System.Globalization;
using exercicio_revisaoarray2;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de produtos adicionados: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Product[] vect = new Product[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nome do {i + 1}o produto: ");
                string name = Console.ReadLine();
                Console.Write($"Valor do {i + 1}o produto: ");               
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product(name, price);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            Console.WriteLine();
            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}