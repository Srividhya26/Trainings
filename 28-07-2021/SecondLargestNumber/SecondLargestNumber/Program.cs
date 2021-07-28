using System;

namespace SecondLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int []arr = { 10, 9, 5, 4, 6 };
            Number(arr);

        }

        public static void Number(int[] arr)
        {
            int len = arr.Length;
            Array.Sort(arr);

            if(len < 2)
            {
                Console.WriteLine("The array does not contain enough elements");
            }

            for(int i = len - 2;i >= 0;i--)
            {
                if(arr[i] != arr[len-1])
                {
                    Console.WriteLine("The second largest number is " + arr[i]);
                    break;
                }
            }

            
        }
    }
}
