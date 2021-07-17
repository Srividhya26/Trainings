using System;
using Student;

namespace AccessModifier
{
    class Internal
    {
        internal string Mname,Fname;
        
        public void parentDetails()
        {
            Console.WriteLine($"Father Name : {Fname} \nMother Name : {Mname}");
        }
    }
    class Program : StudentDB
    {
        static void Main(string[] args)
        {
            Internal parent = new Internal();
            var ave = new Program();
            ave.MyName = "Joseph";
            Console.WriteLine($"The name of the student is {ave.MyName}");
            parent.Fname = "Jackson";
            parent.Mname = "Maria";
            parent.parentDetails();
            var total = ave.total(89, 90, 99, 96, 85);
            Console.WriteLine($"The total marks obtained by {ave.MyName} is {total}");
            var average = total / 5;
            Console.WriteLine("The percentage obtained is " + average);


        }
    }
}
