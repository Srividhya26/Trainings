using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var salaryacc = new SalaryAccount();
            var dematacc = new DematAccount();
            
            salaryacc.Name = "Srividhya";
            salaryacc.AccountId = 67843456;
            salaryacc.Balance = 55000.00;
            

            dematacc.DematAccountNumber = 65784657;
            dematacc.validate("HGFYS7646G");
            dematacc.Years = 4;

            Console.WriteLine($"Name : {salaryacc.Name} \nAccount Number : {salaryacc.AccountId} \nBalance : {salaryacc.Balance}");
            Console.WriteLine($"Demat Account Number : {dematacc.DematAccountNumber}");

            salaryacc.AvailFreeDemandDraft();
            salaryacc.AvailFreeLocker();
            dematacc.AvailFreeCreditScoreCheck();
            dematacc.GetDailyStockUpdates();
            
            
            
        }
    }
}
