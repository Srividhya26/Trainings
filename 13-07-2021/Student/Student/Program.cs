using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student age = new Student();
            var value = age._DOB = Convert.ToDateTime("02/06/2000");
            age.SetDob(value);
            age.GetAge();
        }
    }
}
