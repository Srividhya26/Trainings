using System;

namespace ArithmeticOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic obj = new Arithmetic();
            var add = obj.ArithmeticOperation(10, 9, 8, 7);
            var sub = obj.ArithmeticOperation(3.45D, 4.67D);
            var mul = obj.ArithmeticOperation(7f,4f,8f);
            var div = obj.ArithmeticOperation(11m, 2m);
            Console.WriteLine($" Addition : {add} \n Subtraction : {sub} \n Multiplication : {mul} \n Division : {div}");
        }
    }
}
