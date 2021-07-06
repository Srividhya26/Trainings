using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type casting the values.
            var id = "5124";
            var name = "Johny";
            var salary = "25000";
            int x = Convert.ToInt32(id);
            Console.WriteLine(x);
            Console.WriteLine(name);
            int y = Convert.ToInt32(salary);
            Console.WriteLine(y);

            //Performing operations using different data types.
            var num1 = 10;
            var num2 = 10.2m;
            var res = num1 + num2;
            var result = num2 / num1;
            var num3 = 30.6f;
            var num4 = 20.2f;
            var res1 = num3 * num4;
            Console.WriteLine("The value of all three types is " + res + ", " + result + ", " + res1 );

            //Reversing a character
            char value1, value2, value3;
            Console.WriteLine("Enter the first letter");
            value1 = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("Enter the second letter");
            value2 = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("Enter the third letter");
            value3 = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("{0} {1} {2} ",value3,value2,value1);

            //Performing different operations
            int a, b;
            string c;

            Console.WriteLine("Enter the first input");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second input");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operator");
            c = Console.ReadLine();

            if (c == "+")
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            else if (c == "-")
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            else if (c == "*")
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            else if (c == "/")
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            else
                Console.WriteLine("Enter the valid operator");

            //Comparison and logical operator.
            string s1, s2;
            int rNo1, rNo2;
            Console.WriteLine("Enter the first string");
            s1 = Console.ReadLine();

            Console.WriteLine("Enter the second string");
            s2 = Console.ReadLine();

            int l1 = s1.Length;
            int l2 = s2.Length;

            Console.WriteLine("Enter the first number");
            rNo1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            rNo2 = Convert.ToInt32(Console.ReadLine());

            if(l1 == l2 && rNo1 == rNo2)
                Console.WriteLine("Both are equal");
            else if(l1 >= l2 && rNo1 >= rNo2)
                Console.WriteLine("The first value is greater than second");
            else if(l1 <= l2 && rNo1 <= rNo2)
                Console.WriteLine("The second value is graeter than first");
            else
                Console.WriteLine("Not equal");

            //Different Primitive data type
            var n1 = 1.234f;
            var n2 = 1.234;
            var n3 = 1.234m;
            var n4 = 20;
            var n5 = false;

            Console.WriteLine(n1.GetType());
            Console.WriteLine(n2.GetType());
            Console.WriteLine(n3.GetType());
            Console.WriteLine(n4.GetType());
            Console.WriteLine(n5.GetType());



        }
    }
}
