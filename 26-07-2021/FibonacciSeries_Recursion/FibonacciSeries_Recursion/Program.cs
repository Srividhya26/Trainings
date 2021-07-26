using System;

namespace FibonacciSeries_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciSeries(11);
        }

        public static void FibonacciSeries(int number)
        {
            FibonacciSeries(0,1,1,number);
        }
        public static void FibonacciSeries(int a,int b,int c,int num)
        {
            if(c <= num)
            {
                Console.WriteLine(a);
                FibonacciSeries(b, a + b, c + 1, num);
            }
            
        }
    }
}
