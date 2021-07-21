using System;
using System.Collections.Generic;


namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new StudentList<int, string>();
            students.Add(11, "sri");
            students.Add(12, "Suji");
            students.Add(13, "Manoj");
            students.Add(14, "Mahesh");
            students.Add(15, "Sunitha");

            students.Remove("Sunitha");

            students.Sort(students.ToString());

        }

        public class StudentList<T, T1>
        {
            public void Add(T id,T1 name)
            {
                Console.WriteLine("ID : " + id + " Name : " + name);
            }

            public void Remove(T1 name)
            {
                Console.WriteLine($"The {name} was removed from the Generic Dictionary");
            }

            public void Sort(T1 name)
            {
                Console.WriteLine("The values are sorted");
            }
        }
    }
    
}
