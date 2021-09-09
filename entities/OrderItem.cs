using System;
using EnumComposit.entities;

namespace EnumComposit.entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() {}
        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        
        public double Subtotal() {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Price + ", Quantity: " +
            Quantity + ", Subtotal: $" + Subtotal();
        }
    }
}