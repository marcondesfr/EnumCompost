using System;
using System.Collections.Generic;

namespace EnumComposit.entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public void AddItem(Product product) {
            Products.Add(product);
        }
        public void RemoveItem(Product product) {
            Products.Remove(product);
        }
        public double Subtotal()
        {
            return Quantity * Price;
        }
    }
}