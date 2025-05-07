using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCollectionExercise.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, Product product, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }
                

        public double SubTotal()
        {
            return Quantity * Product.ProdPrice;
        }

        public override string ToString()
        {
            return $"${Product}, Quantity: {Quantity}, Subtotal: ${SubTotal()}";
        }
    }
}
