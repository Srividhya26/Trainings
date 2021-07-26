using System;

namespace StringReversal_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringReverse("hello");
        }

        public static void StringReverse(string text)
        {
            int len = text.Length;   
            if(len <= 1)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.Write(text[len - 1]);
                StringReverse(text.Substring(0, (len - 1)));
            }
        }
    }
}
