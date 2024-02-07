using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex12.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            double ret = Quantity * Price;
            return ret;
        }
    }
}