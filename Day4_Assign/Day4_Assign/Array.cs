using System;
using System.Collections;


namespace Day4_Assign
{
    public class Array
    {
        public static void Main(string[] args) 
        {
            int[] arr = new int[10];// { 3, 5, 9, 2, 3, 9, 5, 1, 8, 7 };
            Console.WriteLine("Enter the array values");
            for (int n = 0; n < 10 ;n++)
            {
               arr[n] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The duplicate arrays in a list");
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[j]);
                }
            }
            



        }
    }
}
