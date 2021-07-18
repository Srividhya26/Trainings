using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Constructors
{
    class SalaryAccount
    {
        public float AccountId;
        public string Name;
        public double Balance;

        public SalaryAccount()
        {

        }
        public SalaryAccount(float accountId,string name,double balance)
        {
            this.AccountId = accountId;
            this.Name = name;
            this.Balance = balance;
        }
    }

    class DematAccount : SalaryAccount
    {
        public float DematAccountNumber;
        public DematAccount()
        {

        }
        public DematAccount(float dematAccNo)
        {
            this.DematAccountNumber = dematAccNo;
        }

        public void validate(string pan)
        {
            
            Regex pattern = new Regex(@"[A-Z]{5}[0-9]{4}[A-Z]{1}");
            Match match = pattern.Match(pan);
            if (match.Success)
            {
              Console.WriteLine($"PAN No : {pan}");
;           }
            else 
            {
                throw new Exception("Enter the valid PAN");
            }
           
            
        }
    }
}
