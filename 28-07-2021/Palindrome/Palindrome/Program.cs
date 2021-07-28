using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome("MALAYALAM");
        }

        public static void Palindrome(string text)
        {
            string rev = "";
            int len = text.Length - 1;
            while(len >= 0)
            {
                rev = rev + text[len];
                len--;
            }
            Console.WriteLine(rev);
            if(text == rev)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
        }
    }
}
