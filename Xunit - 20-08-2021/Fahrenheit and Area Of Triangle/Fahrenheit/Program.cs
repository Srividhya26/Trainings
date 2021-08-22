using System;

namespace Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var res1 = Methods.Convert(97);
            var res2 = Methods.Convert(-89);
            Console.WriteLine(res1);
            Console.WriteLine(res2);

            var area = Methods.AreaOfTriangle(10, 20);
            Console.WriteLine(area);
        }
    }
}
