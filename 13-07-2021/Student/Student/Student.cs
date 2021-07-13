using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public int Id;
        public string Name;
        public DateTime _DOB;
        public TimeSpan Age;

        public Student()
        {

        }

        public Student(int id,string name,DateTime dob,TimeSpan age)
        {
            this.Id = id;
            this.Name = name;
            this._DOB = dob;
            this.Age = age;
        }
        
        public DateTime SetDob(DateTime dateTime)
        {
            _DOB = dateTime;
            return _DOB;
        }

        public void GetAge()
        {
            var currentDate = DateTime.Now;
            int Years = new DateTime(currentDate.Subtract(_DOB).Ticks).Year - 1;
            Console.WriteLine("The current age is " + Years + " years");
        }




    }
}
