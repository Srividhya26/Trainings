using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersDetails
{
    class Customer
    {
        private string bloodGroup;
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public  int Age { get; set; }
        public string BloodGroup 
        {
            get { return bloodGroup; }
            set {bloodGroup = value; }  
        }

        public Customer()
        {

        }

        //public Customer(int custId,string name,int age,string bloodGroup)
        //{
        //    this.CustomerId = custId;
        //    this.Name = name;
        //    this.BloodGroup = bloodGroup;
        //    this.Age = age;
        //}

    }

    
}
