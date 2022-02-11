using System;
using System.Globalization;
using Interface.Entities;
using Interface.Services;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rental Data: ");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finishDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Price per hour: ");
            double priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Price per day: ");
            double priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(startDate, finishDate, new Vehicle(model));

            RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.Write(carRental.Invoice);

        }
    }
}
