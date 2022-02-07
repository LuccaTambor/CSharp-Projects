using System;
using System.Collections.Generic;
using Composition.Entities.Enums;

namespace Composition.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } 
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();//List of HourContracts of each worker

        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContrat(HourContract contract)
        {
            Contracts.Remove(contract); 
        }

        //Gets the income of a worker in a especific month, by getting the total value of each of the workers
        //Contracts for that month
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}
