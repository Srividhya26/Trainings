using System;
using Demo;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var info = new Class1();
                var result = info.Find();
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
