using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICalculateProfit
{
    double CalculateInterest(double amount, int years);
}

public interface IBankAccount
{
    void GenerateExtract();
    double Balance { get; set; }
    void Withdraw(double amount);
    void Deposit(double amount);
}

public class DemandDepositAccount : IBankAccount
{
    public void GenerateExtract()
    {
        Console.WriteLine("Extract: ");
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("Interest: " + CalculateInterest(Balance, 1));
        Console.WriteLine("Total: " + (Balance + CalculateInterest(Balance, 1)));
        Console.WriteLine();
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}

public class CoopAccount : IBankAccount, ICalculateProfit
{
    public void GenerateExtract()
    {
        Console.WriteLine("Extract: ");
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("Interest: " + CalculateInterest(Balance, 1));
        Console.WriteLine("Total: " + (Balance + CalculateInterest(Balance, 1)));
        Console.WriteLine();
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public double CalculateInterest(double amount, int years)
    {
        return amount * 0.05 * years;
    }
}

public class undemandDepositAccount : IBankAccount, ICalculateProfit
{
    public void GenerateExtract()
    {
        Console.WriteLine("Extract: ");
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("Interest: " + CalculateInterest(Balance, 1));
        Console.WriteLine("Total: " + (Balance + CalculateInterest(Balance, 1)));
        Console.WriteLine();
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public double CalculateInterest(double amount, int years)
    {
        return amount * 0.01 * years;
    }
}







