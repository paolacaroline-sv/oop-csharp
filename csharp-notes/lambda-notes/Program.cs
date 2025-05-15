using lambda_notes.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace lambda_notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            string path = @"C:\temp\in.txt"; //exemple: Tv,900.00
            Console.WriteLine("** ok!");

            List<Product> products = new List<Product>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                        products.Add(new Product(name, price));
                    }
                }

                var averagePrices =
                (from p in products
                 select p.Price).Average();
                Console.WriteLine("Avarage price products: " + averagePrices.ToString("F2", CultureInfo.InvariantCulture));

                var namesProd =
                    from p in products
                    where p.Price < averagePrices
                    orderby p.Price descending
                    select p.Name;
                foreach (var name in namesProd)
                {
                    Console.WriteLine(name);
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("Ops!");
                Console.WriteLine(e.Message);
            }
        }
    }
}