using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Interfaces
{
    class DematAccount : SalaryAccount
    {

        public float DematAccountNumber;
        public int Years;
        public DematAccount()
        {
           
        }
        public DematAccount(float dematAccNo, int years)
        {
            this.DematAccountNumber = dematAccNo;
            this.Years = years;
        }

        public void validate(string pan)
        {

            Regex pattern = new Regex(@"[A-Z]{5}[0-9]{4}[A-Z]{1}");
            Match match = pattern.Match(pan);
            if (match.Success)
            {
                Console.WriteLine($"PAN No : {pan}");
                ;
            }
            else
            {
                throw new Exception("Enter the valid PAN");
            }


        }

        public void AvailFreeCreditScoreCheck()
        {
            if (Years > 2)
            {
                Console.WriteLine(" Congragulations!! On being the demat account holder for more than two years.Now you can avail your free credit score check.");
            }
        }

        public void GetDailyStockUpdates()
        {
            if (Years > 1)
            {
                Console.WriteLine(" Get your daily stock updates now!");
            }
        }

        


    }
}
