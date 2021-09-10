using System;
using System.Text;
using System.Collections.Generic;
using EnumComposit.entities.Enums;

namespace EnumComposit.entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Products { get; set; } = new List<OrderItem>();
        
        public Order() {}
        public Order(DateTime moment, OderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem product) {
            Products.Add(product);
        }

        public void RemoveItem(OrderItem product) {
            Products.Remove(product);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem Product in Products) {
                sum += Product.Subtotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach( OrderItem item in Products) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            return sb.ToString();

        }
    }
}