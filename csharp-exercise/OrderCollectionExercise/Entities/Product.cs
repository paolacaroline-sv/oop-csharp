using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCollectionExercise.Entities
{
    internal class Product
    {
        
        public string Name { get; set; }
        public double ProdPrice { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            ProdPrice = price;
        }
        public override string ToString()
        {
            return Name + ", $" + ProdPrice;
        }
    }
    
}
