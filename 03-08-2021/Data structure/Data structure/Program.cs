using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 5, 10, 15, 20, 3 };
            var myNewArr = new List<int>();

            int i = 0;
            while( i < arr.Length)
            {
                int sum = 0;
                sum = (arr.Sum()) - arr[i];
                myNewArr.Add(sum);
                i++;
            }

            foreach (var ele in myNewArr.ToArray())
                Console.WriteLine(ele + " ");
        }
    }
}
