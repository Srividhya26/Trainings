using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interfaces
{
    class SalaryAccount:IBenefits
    {
        public float AccountId;
        public string Name;
        public double Balance;

        public SalaryAccount()
        {
            
        }
        public SalaryAccount(float accountId, string name, double balance)
        {
            this.AccountId = accountId;
            this.Name = name;
            this.Balance = balance;
        }

        public void AvailFreeDemandDraft()
        {
            if (Balance > 20000)
            {
                Console.WriteLine(" You have now free demand draft with you.Use it now!");
            }
        }

        public void AvailFreeLocker()
        {
            if (Balance > 50000)
            {
                Console.WriteLine(" You can now make use of free locker to store your valuables!!");
            }
        }
    }

    
}
