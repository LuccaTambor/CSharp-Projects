using System;
using System.Globalization;
using Composition2.Entities;
using Composition2.Entities.Enums;

namespace Composition2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting clinet data
            Console.WriteLine("Enter client data:");
            Console.Write("Name:");
            string clientName = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Birth Data (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //instaciating a client
            Client client = new Client(clientName, email, birthDate);

            //Getting the orde's data
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? :");
            int n = int.Parse(Console.ReadLine());

            //instaciating an order
            Order order = new Order(DateTime.Now, status, client);

            //getting all items of the order
            for(int i = 1; i <= n; i++)
            {
                //Getting all items data
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(prodName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                //Instanciating item
                OrderItem item = new OrderItem(quantity, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            //Order sumarry
            Console.WriteLine(order);
        }
    }
}
