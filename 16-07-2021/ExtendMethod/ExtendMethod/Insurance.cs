using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtendMethod
{
    class Insurance
    {
        public string name;
        public string email;
        public DateTime premiumdate;
        public string aadhaarno;


        public string Name 
        {
            get {return name; }
            set { name = value; }
           
        }
        public string Email 
        {
            get { return email; }
            set 
            {
                Regex pattern = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                Match match = pattern.Match(email);
                if (match.Success)
                {
                    Console.WriteLine("Email verification completed successfully");
                }
                else
                {
                    throw new Exception("Enter the valid Email address");
                }
                
            } 
        }
        public DateTime PremiumDueDate 
        {
            get {return premiumdate; }
            set {premiumdate = value; } 
        }
        public string AadhaarcardNo 
        {
            get { return aadhaarno; }
            set
            {
                Regex pattern = new Regex("^[2-9]{1}[0-9]{3}\\s[0-9]{4}\\s[0-9]{4}$");
                Match match = pattern.Match(aadhaarno);
                if (match.Success)
                {
                    Console.WriteLine("Aadhaar verification completed successfully");
                }
                else
                {
                    throw new Exception("Enter the valid aadhaar no");
                }
            }
        }

        public void PayPremium(string scheme)
        {
            if(scheme == "Life Insurance")
            {
                Console.WriteLine("The amount to be paid every month is 20,000");
            }
            else if(scheme == "Vehicle Insurance")
            {
                Console.WriteLine("The amount to be paid annually is 25,000");
            }
            else if(scheme == "Medical Insurance")
            {
                Console.WriteLine("The amount to be paid annually is 30,000");
            }
        }
    }

    //Extension Method
    static class Extension
    {
        public static void GetDueDate(this Insurance due)
        {
            Insurance ins = new Insurance();
            var pendingDate = ins.PremiumDueDate = Convert.ToDateTime("15/07/2021");
            DateTime dueDate = pendingDate;
            DateTime todayDate = DateTime.Now;
            TimeSpan ts = dueDate - todayDate;
            Console.WriteLine("The remaining days to pay the amount is " + ts.Days + " days");           
        }

    }

    
}
