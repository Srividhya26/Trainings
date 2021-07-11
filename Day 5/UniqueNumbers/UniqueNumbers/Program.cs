using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace UniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList newArray = new ArrayList();
            ArrayList uniqueItems = new ArrayList();
            string value;
            Console.WriteLine("Enter the values");
            while (true)
            {
                value = Console.ReadLine();
                if (value == "quit")
                {
                    break;
                }
                newArray.Add(value);

            }
            object[] obj1 = newArray.ToArray();
            for (int i = 0; i < obj1.Length; i++)
            {
                for (int j = i + 1; j < obj1.Length; j++)
                {
                    if (obj1[i] != obj1[j])
                    {
                        uniqueItems.Add(obj1[i]);
                    }
                }
            }
            Console.WriteLine("Unique items are");
            foreach (var item in uniqueItems)
            {
                Console.WriteLine(item + " ");
            }








        }
    }
}
