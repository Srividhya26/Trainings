using System;

namespace ArithmeticOperation
{
    public static class Program
    {
        public static int Add(params int[] myValue)
        {
            int sum = 0;
            for(int i=0;i<myValue.Length;i++)
            {
                sum += myValue[i];
            }
            return sum;
        }

       
        public static double Sub(double a, double b)
        {
            return a - b;
        }

        public static float Mul(params float[] myValue)
        {
            float mul = 1f;
            for (int i = 0; i < myValue.Length; i++)
            {
                mul *= myValue[i];
            }
            return mul;
        }

        public static decimal Div(decimal a, decimal b)
        {
            return a / b;
        }
    }
}

class MainProgram
{
    static void Main(string[] args)
    {
        
    }
}



