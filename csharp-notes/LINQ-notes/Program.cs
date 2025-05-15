using LINQ_notes.Entities;
using System;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace LINQ_notes
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T x in collection)
            {
                Console.WriteLine(x);
            }
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900);
            Console.WriteLine("** TIER 1 AND PRICE LESS THAN $900");
            foreach (var x in r1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            var r2 = products.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            Print("** NAME OF PRODUCTS from TOOLS", r2);
            Console.WriteLine();

            var r3 = products.Where(x => x.Name.StartsWith('C') || x.Name.StartsWith('c')).Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name });
            Print("** NAME STARTS WITH 'C'", r3);
            Console.WriteLine();

            var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            Print("** TIER 1 AND ORDERBY PRICE THENBY NAME", r4);
            Console.WriteLine();

            var r5 = r4.Skip(2).Take(2);
            Print("** SKIP 2 ELEMENTS FROM ANOTHER DATASOURCE AND TAKE JUST 2", r5);
            Console.WriteLine();

            var r6 = products.First();
            Console.WriteLine("** FIRST PRODUCT: " + r6);
            Console.WriteLine();


            var r7 = products.Where(x => x.Price > 23342).FirstOrDefault();
            Console.WriteLine("** 'FIRST OR DEFAULT' PRODUCT PRICE > 23342: " + r7);
            Console.WriteLine();


            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("** SINGLE OR DEFAULT: " + r8);
            Console.WriteLine();

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("** SINGLE OR DEFAULT: " + r9);
            Console.WriteLine();


            var r10 = products.Max(p => p.Price);
            Console.WriteLine("** MAX PRICE: " + r10);
            Console.WriteLine();

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("** MIN PRICE: " + r11);
            Console.WriteLine();


            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("** CATEGORY 1 - SUM PRICES: " + r12);
            Console.WriteLine();

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("** CATEGORY 1 - AVERAGE PRICES: " + r13);
            Console.WriteLine();

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0).Average();
            Console.WriteLine("** CATEGORY 5 - AVERAGE PRICES: " + r14);
            Console.WriteLine();

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("** MapReduce - Select Aggregate: " + r15);
            Console.WriteLine();


            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> grupo in r16)
            {
                Console.WriteLine("Category " + grupo.Key.Name + ": ");
                foreach (Product p in grupo)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}