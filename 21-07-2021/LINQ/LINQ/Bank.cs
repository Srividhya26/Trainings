using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Bank
    {
        static void Main(string[] args)
        {
            var branches = new List<Branches> 
            { 
                new Branches { BankName = "ICICI" , PhoneNumber = 9647534637 , BranchLocation = "Anna nagar",MaxPoints = 90 },
                new Branches { BankName = "IOB" , PhoneNumber = 9879038477 , BranchLocation = "Chrompet", MaxPoints = 89 },
                new Branches { BankName = "SBI" , PhoneNumber = 9885382230 , BranchLocation = "KK Nagar", MaxPoints = 75 },
                new Branches { BankName = "KOB" , PhoneNumber = 9940232176 , BranchLocation = "Pammal", MaxPoints = 85 },
                new Branches { BankName = "Indian Bank" , PhoneNumber = 8414123990 , BranchLocation = "Anna nagar", MaxPoints = 80 }
            };

            var managers = new List<Managers> 
            { 
                new Managers { ManagerId = 101 , ManagerName = "Sai" , ManagerBankName = "ICICI",Age = 32},
                new Managers { ManagerId = 102 , ManagerName = "Jeni", ManagerBankName = "IOB",Age = 28},
                new Managers { ManagerId = 103 , ManagerName = "Deva", ManagerBankName = "SBI",Age = 29},
                new Managers { ManagerId = 104 , ManagerName = "Divya", ManagerBankName = "SBI",Age = 35},
                new Managers { ManagerId = 105 , ManagerName = "Sri", ManagerBankName = "Indian Bank",Age = 30}
            };

            var join = branches.Join(managers,
                                      b => b.BankName,
                                      m => m.ManagerBankName,
                                      (b,m) => new
                                      {
                                          BranchBankName = b.BankName,
                                          ManagerBankName = m.ManagerBankName,
                                          ManagerName = m.ManagerName,
                                          Age = m.Age,
                                          MaximumPoints = b.MaxPoints,
                                      });
            Console.WriteLine("To display branches and respective managers \n");

            foreach (var name in join)
            {
                Console.WriteLine("Branch Name : " + name.BranchBankName + ", Manager Name : " + name.ManagerName);
            }

            Console.WriteLine("\nThe Managers aged above 30 \n");

            foreach (var age in join)
            {
                if (age.Age > 30)
                {
                    Console.WriteLine("Manager Name : " + age.ManagerName + ", Bank Name : " + age.BranchBankName);
                }

            }

            Console.WriteLine("\nManager who scored maximum points out of 100");

            foreach(var max in join)
            {
                if(max.MaximumPoints == branches.Max(m => m.MaxPoints))
                {
                    Console.WriteLine(max.ManagerName);
                }
            }
            
      

        }

        public class Branches
        {
            public string BankName { get; set; }
            public long PhoneNumber{ get; set; }
            public string BranchLocation { get; set; }
            public int MaxPoints { get; set; }
        }

        public class Managers
        {
            public int ManagerId { get; set; }
            public string ManagerName { get; set; }
            public string  ManagerBankName { get; set; }
            public int Age { get; set; }

        }
    }
}
