using System;
using System.Globalization;
using Composition.Entities;
using Composition.Entities.Enums;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating and recivving the data for the Entities
            
            //Workers data
            Console.Write("Enter deparment's name:");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Department Data
            Department dept = new Department(deptName);

            //Instanciating Worker
            Worker worker = new Worker(name, level, baseSalary, dept);

            
            Console.Write("How many contracts to this worker? :");
            int n = int.Parse(Console.ReadLine());

            //Getting the data for each one of the workers contract
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }

            //Showing the data
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();

            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse((monthYear.Substring(3)));

            Console.WriteLine("Name: " +worker.Name);
            Console.WriteLine("Departmente: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
