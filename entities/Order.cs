using System;
using System.Text;
using System.Collections.Generic;
using EnumComposit.entities.Enums;

namespace EnumComposit.entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Items = new List<OrderItem>();

        public Order() {}
        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }
        public double Total() {
            double sum = 0.0;
            foreach(OrderItem item in Items) {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sub = new StringBuilder();

            sub.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sub.AppendLine("Order Status: " + Status);
            sub.AppendLine("Client: " + Client);
            sub.AppendLine("Order items:");
            foreach(OrderItem item in Items) {
                sub.AppendLine(item.ToString());
            }
            sub.AppendLine("TOTAL: " + Total().ToString("F2"));
            return sub.ToString();
        }
    }
}