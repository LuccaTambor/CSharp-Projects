using System;
using Exceptions.Entities;
using Exceptions.Entities.Exceptions;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in Data (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Data (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in Data (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Data (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: "+ e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpect Error: " + e.Message);
            }
       
        }
    }
}
 