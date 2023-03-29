using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                Id = 1,
                Name = "Miraç",
                HourlyRate = 15.5,
                WorkingHours = 160
            };
            var calculator = new SalaryCalculator();
            var totalSalary = calculator.CalculateTotalSalary(employee);
            Console.WriteLine($"Total salary of {employee.Name} is {totalSalary}");
        }
    }
}