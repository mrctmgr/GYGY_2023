using System;

public class SalaryCalculator
{
    public double CalculateTotalSalary(Employee employee)
    {
        return employee.HourlyRate * employee.WorkingHours;
    }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double HourlyRate { get; set; }
    public int WorkingHours { get; set; }
}

public interface ISalaryCalculator
{
    double CalculateTotalSalary(Employee employee);
}

public class SalaryCalculatorModified : ISalaryCalculator
{
    public double CalculateTotalSalary(Employee employee)
    {
        return employee.HourlyRate * employee.WorkingHours;
    }
}

public class EmployeeModified
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double HourlyRate { get; set; }
    public int WorkingHours { get; set; }

    public EmployeeDetailsModified(ISalaryCalculator salaryCalculator)
    {
        SalaryCalculator = salaryCalculator;
    }
    public float GetSalary()
    {
        return SalaryCalculator.CalculateTotalSalary(WorkingHours);
    }
}
