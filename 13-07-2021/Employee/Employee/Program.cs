using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetSalary(20000);
            emp.GetSalary();
            var newSalary = emp.Promote(true);
            Console.WriteLine($"Increased Salary is {newSalary}");
        }
    }
}
