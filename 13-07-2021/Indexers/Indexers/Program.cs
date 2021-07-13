using System;
using System.Collections;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails details = new EmployeeDetails();
            details[1] = new string("sri");
            details[2] = new string("Jacob");
            details[3] = new string("Jaison");
            details[4] = new string("Rosy");
            Console.WriteLine(details[1]);
            Console.WriteLine(details[2]);
            Console.WriteLine(details[3]);
            Console.WriteLine(details[4]);
        }
    }
}
