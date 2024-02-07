using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex12.Entities.Enum;
using System.Globalization;
using ex12.Entities;

namespace ex12.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; } = new Client();
        public List<OrderItem> OrderItem { get; private set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }
        public double Total()
        {
            double ret = 0;
            
            foreach (OrderItem item in OrderItem)
            {
                ret += item.SubTotal();
            }

            return ret;
        }
    }

}