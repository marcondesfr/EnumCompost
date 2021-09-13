using System;
using System.Globalization;
using EnumComposit.entities.Enums;
using EnumComposit.entities;

namespace EnumComposit
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("ENTER CLIENT DATA:");
            System.Console.Write("NAME: ");
            string name = Console.ReadLine();
            System.Console.Write("EMAIL: ");
            string email = Console.ReadLine();
            System.Console.Write("BIRTH DATE (DD/MM/YYYY): ");
            string b = Console.ReadLine();
            DateTime birth = DateTime.Parse(b, CultureInfo.GetCultureInfo("pt-BR"));
            System.Console.WriteLine();
            System.Console.WriteLine("ENTER ORDER DATA:");
            System.Console.Write("STATUS: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client Client = new Client(name, email, birth);
            Order Order = new Order(DateTime.Now, status, Client);

            System.Console.Write("HOW MANY ITENS TO THIS ORDER? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                System.Console.WriteLine($"ENTER #{i} ITEM DATA:");
                System.Console.Write("PRODUCT NAME: ");
                string NameProduct = Console.ReadLine();
                System.Console.Write("PRODUCT PRICE: ");
                double PriceProduct = double.Parse(Console.ReadLine());

                Product Product = new Product(NameProduct, PriceProduct);

                System.Console.Write("QUANTITY: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem OrderItem = new OrderItem(quantity, PriceProduct, Product);

                Order.AddItem(OrderItem);
                
            }
            System.Console.WriteLine();
            System.Console.WriteLine("ORDER SUMMARY:");
            System.Console.WriteLine(Order);
            
        }
    }
}
