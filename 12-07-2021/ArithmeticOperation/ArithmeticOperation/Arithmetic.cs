using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperation
{
    class Arithmetic
    {
        public int ArithmeticOperation(params int[] myValue)
        {
            int sum = 0;
            for (int i = 0; i < myValue.Length; i++)
            {
                sum += myValue[i];
            }
            return sum;
        }

        public double ArithmeticOperation(double a , double b)
        {
            return a - b;
        }

        public float ArithmeticOperation(params float[] myValue)
        {
            float mul = 1f;
            for(int i = 0; i < myValue.Length; i++)
            {
                mul *= myValue[i];
            }
            return mul;
        }

        public decimal ArithmeticOperation(decimal a, decimal b)
        {
            return a / b ;
        }

    }
}
