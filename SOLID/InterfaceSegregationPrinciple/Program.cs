using InterestCalculator;
using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var demandDepositAccount = new DemandDepositAccount();
            demandDepositAccount.Deposit(1000);
            demandDepositAccount.GenerateExtract();

            var coopAccount = new CoopAccount();
            coopAccount.Deposit(1000);
            coopAccount.GenerateExtract();
        }
    }
}