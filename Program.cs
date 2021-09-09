using System;
using EnumComposit.entities.Enums;
using EnumComposit.entities;

namespace EnumComposit
{
    class Program
    {
        static void Main(string[] args)
        {   
            Client c;
            //Enter client data
            System.Console.WriteLine("Enter cliente data:");
            System.Console.Write("Name: ");
            string Name = Console.ReadLine();
            System.Console.Write("Email: ");
            string Email = Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime Birth = DateTime.Parse(Console.ReadLine());
            //Enter status order
            System.Console.WriteLine("Enter order data:");
            System.Console.Write("Status: ");
            int Status = int.Parse(Console.ReadLine());
            c = new Client(Name, Email, Birth);
            

        }
    }
}
