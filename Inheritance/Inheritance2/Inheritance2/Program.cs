using System;
using System.Globalization;
using System.Collections.Generic;
using Inheritance2.Entities;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> Products = new List<Product>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} Data:");
                Console.Write("Commom, used or imported (c/u/i)? :");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'c')
                {
                    Product product = new Product(name, price);
                    Products.Add(product);
                }
                else if (op == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Product product = new UsedProduct(name, price, date);
                    Products.Add(product);
                }
                else if (op == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product product = new ImportedProduct(name, price, fee);
                    Products.Add(product);
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product product in Products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
