using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public int EmployeeId;
        public string Name;
        public string Designation;
        private double _salary;

        public Employee()
        {

        }
        public Employee(int id,string name,string designation,double salary)
        {
            this.EmployeeId = id;
            this.Name = name;
            this.Designation = designation;
            this._salary = salary;
        }

        public void GetSalary()
        {
            Console.WriteLine($"Current Salary is {_salary} ");
        }

        public void SetSalary(double salary)
        {
            _salary = salary;
        }

        public double Promote(bool value)
        {
            if(value == true)
            {
                _salary = IncreasedPay();
            }
            return _salary;
        }
        private double IncreasedPay()
        {
            _salary = _salary + (_salary * 10 / 100);
            return _salary;
        }

    }
}
