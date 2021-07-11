using System;
using System.Collections.Generic;
using System.Linq;

namespace LargeText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the character upto which you want to display");
            int key = Convert.ToInt32(Console.ReadLine());
            if ((text == null))
            {
                Console.WriteLine("The text is empty");
            }
            else if(text.Length <= key)
            {
                Console.WriteLine("The text is less than key ");
            }
            else
            {
                Console.WriteLine(text.Substring(0, text.IndexOf(" ", key)));
            }
            string newText = String.Join(" ", text.Split(' ').Take(key));
        }
    }
}
