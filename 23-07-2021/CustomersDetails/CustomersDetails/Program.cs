using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomersDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            FindBloodGroup();
        }

        

        public static void AddDetails()
        {
            List<Customer> newCustomers = new List<Customer>
                {
                    new Customer{CustomerId = 101 , Name = "Sri" ,Age = 58},
                    new Customer{CustomerId = 106 , Name = "Rathi" ,Age = 45 },
                    new Customer{CustomerId = 103 , Name = "Durga" ,Age = 60},
                    new Customer{CustomerId = 108 , Name = "Hema" ,Age = 34},
                    new Customer{CustomerId = 109 , Name = "Vidhya" ,Age = 63 },
                };
                

            

            List<MedicalInsurance> medicalInsurance = new List<MedicalInsurance>
            {
                new MedicalInsurance{InsuranceId = 3456,Validity = Convert.ToDateTime("05/07/2047") , PremiumAmount = 10000,ListOfAppointmentsCompleted = 1,Age = 58,CustomerId = 101},
                new MedicalInsurance{InsuranceId = 3340,Validity = Convert.ToDateTime("07/08/2048") , PremiumAmount = 15000,ListOfAppointmentsCompleted = 2,Age = 45,CustomerId = 102},
                new MedicalInsurance{InsuranceId = 3500,Validity = Convert.ToDateTime("10/05/2050") , PremiumAmount = 20000,ListOfAppointmentsCompleted = 2,Age = 60,CustomerId = 103},
                new MedicalInsurance{InsuranceId = 3650,Validity = Convert.ToDateTime("19/11/2035") , PremiumAmount = 25000,ListOfAppointmentsCompleted = 7,Age = 34,CustomerId = 104},
                new MedicalInsurance{InsuranceId = 3900,Validity = Convert.ToDateTime("09/12/2025") , PremiumAmount = 30000,ListOfAppointmentsCompleted = 2,Age = 63,CustomerId = 105},
            };


            List<LifeInsurance> lifeInsurance = new List<LifeInsurance>
            {
                new LifeInsurance{PremiumAmount = 100000,Nominee = "Krithika",MaturityDate = Convert.ToDateTime("04/03/2027"),InsuranceId = 3645,CustomerId = 101,Age = 58,Validity = Convert.ToDateTime("09/08/2034")},
                new LifeInsurance{PremiumAmount = 150000,Nominee = "Manoj",MaturityDate = Convert.ToDateTime("09/03/2030"),InsuranceId = 4657,CustomerId = 102,Age =56 ,Validity = Convert.ToDateTime("10/11/2035")},
                new LifeInsurance{PremiumAmount = 200000,Nominee = "Rithvika",MaturityDate = Convert.ToDateTime("19/09/2035"),InsuranceId = 7886,CustomerId = 103,Age = 45,Validity = Convert.ToDateTime("18/09/2040")},
                new LifeInsurance{PremiumAmount = 80000,Nominee = "Shobana",MaturityDate = Convert.ToDateTime("08/12/2035"),InsuranceId = 3546,CustomerId = 104,Age = 35,Validity = Convert.ToDateTime("17/01/2025")},
                new LifeInsurance{PremiumAmount = 90000,Nominee = "Anjali",MaturityDate = Convert.ToDateTime("10/08/2040"),InsuranceId = 3990,CustomerId = 105,Age = 29,Validity = Convert.ToDateTime("18/10/2030")},
            };



            var insurence = new InsuranceDetails();
            var join = medicalInsurance.Join(newCustomers,
                                             c => c.CustomerId,
                                             m => m.CustomerId,
                                             (c, m) => new
                                             {
                                                 Name = m.Name,
                                                 CustomerId = c.CustomerId,
                                                 MedicalCustomerId = m.CustomerId,
                                                 NumberOfAppointment = c.ListOfAppointmentsCompleted,
                                                 InsurerAge = insurence.Age,
                                                 Age = c.Age,
                                             }); 
            foreach (var item in join)
            {
                if (item.CustomerId == item.MedicalCustomerId)
                {
                    if(item.NumberOfAppointment <= 2 && item.InsurerAge <= 60)
                    {
                        Console.WriteLine($"Name : {item.Name} \nCustomer ID = {item.CustomerId} \nAge : {item.Age}\nNumber of Appointments : {item.NumberOfAppointment}");
                    }
                }

                else
                {
                    Console.WriteLine("id not found");
                }
            }
    
        }

        public static void FindBloodGroup()
        {
            var bg = new Customer();
            bg.BloodGroup = "B Positive";
            Console.WriteLine("Enter the blood group");
            var bloodGroup = Console.ReadLine();
            if(bloodGroup == bg.BloodGroup)
            {
                AddDetails();
            }
            else
            {
                Console.WriteLine("The entered blood group is not found in the record");
            }
        }

    }
    

}

