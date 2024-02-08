using System;
using System.Globalization;

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
        public override string ToString()
        {
            return $"{Product.Name}, $ {Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, Subtotal: $ {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}