using System;
using System.Collections;

namespace CountNames
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList newArray = new ArrayList();
            string names;
            Console.WriteLine("Enter names");
            while (true)
            {
                names = Console.ReadLine();
                if(names == " ")
                {
                    break;
                }
                newArray.Add(names);
            }
                var total = newArray.Count;
                if (total > 2)
                {
                    Console.WriteLine($" {newArray[0]} , {newArray[1]} and other {total-2} likes your post");
                }
                else if (total == 2)
                {
                    Console.WriteLine($"{newArray[0]} , {newArray[1]}likes yout post");
                }
                else if (total == 1)
                {
                    Console.WriteLine($"{newArray[0]} likes your post");
                }
                else
                {
                    Console.WriteLine(" ");
                }
            
            
        }
    }
}
