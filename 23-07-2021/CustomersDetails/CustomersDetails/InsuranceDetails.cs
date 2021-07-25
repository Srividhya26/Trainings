using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersDetails
{
    class InsuranceDetails
    {
        public int InsuranceId { get; set; }
        public DateTime  Validity { get; set; }
        public int Age { get; set; }
        public int CustomerId { get; set; }

        public InsuranceDetails()
        {

        }

        //public InsuranceDetails(int insuranceId,DateTime validity,int age,int custId)
        //{
        //    this.InsuranceId = insuranceId;
        //    this.Validity = validity;
        //    this.Age = age;
        //    this.CustomerId = custId;
        //}

    }

    class MedicalInsurance:InsuranceDetails
    {
        public double PremiumAmount { get; set; }
        public int ListOfAppointmentsCompleted { get; set; }

        public MedicalInsurance()
        {

        }

        //public MedicalInsurance(double premiumAmount,int listOfAppointment,InsuranceDetails details)
        //{
        //    this.PremiumAmount = premiumAmount;
        //    this.ListOfAppointmentsCompleted = listOfAppointment;
            
        //}
       
    }

    class LifeInsurance:InsuranceDetails
    {
        public double PremiumAmount { get; set; }
        public string Nominee { get; set; }
        public DateTime MaturityDate { get; set; }

        public LifeInsurance()
        {

        }

        public LifeInsurance(double premiumAmount,string nominee,DateTime maturityDate,InsuranceDetails details)
        {
            this.PremiumAmount = premiumAmount;
            this.MaturityDate = maturityDate;
            this.Nominee = nominee;
        }
    }
}
