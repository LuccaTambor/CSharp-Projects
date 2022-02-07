using System;
using System.Collections.Generic;
using Inheritance.Entities;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> Employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} : ");
                Console.Write("Outsourced (y/n)? : ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (op == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double addCharge = double.Parse(Console.ReadLine());

                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, addCharge);
                    Employees.Add(employee);
                }
                else if (op == 'n')
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    Employees.Add(employee);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach(Employee employee in Employees)
            {
                Console.WriteLine($"{employee.Name} - $ {employee.Payment()}");
            }

        }
    }
}
