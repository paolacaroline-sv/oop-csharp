using System;
using equals_gethashcode_notes.Entities;

namespace equals_gethashcode_notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail"};
            Client b = new Client { Name = "Alex", Email = "alex@gmail" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.WriteLine(a == b);
        }
    }
}