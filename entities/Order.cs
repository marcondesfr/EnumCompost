using System;
using System.Collections.Generic;
using EnumComposit.entities.Enums;

namespace EnumComposit.entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OderStatus OrderStatus { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        
        public void AddItem(Product product) {
            Products.Add(product);
        }

        public void RemoveItem(Product product) {
            Products.Remove(product);
        }
    }
}