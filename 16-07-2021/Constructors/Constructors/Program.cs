using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var salaryacc = new SalaryAccount();
            var dematacc = new DematAccount();
            var sc = (DematAccount)salaryacc;
            salaryacc.Name = "Srividhya";
            salaryacc.AccountId = 67843456;
            salaryacc.Balance = 50000.00;
            sc.DematAccountNumber = 867487854;
            sc.validate("GTYDV7658H");
            Console.WriteLine($"Name : {salaryacc.Name} \nAccount Number : {salaryacc.AccountId} \nBalance : {salaryacc.Balance}");
            Console.WriteLine($"Demat Account Number : {sc.DematAccountNumber}");
        }
    }
}
