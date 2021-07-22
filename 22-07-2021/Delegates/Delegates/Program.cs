using System;

namespace Delegates
{
    class Program
    {
        public delegate void myHandler(Letter letter);
        static void Main(string[] args)
        {
            var text = new Letter() { text = "Hello all", firstName = "Ramesh", lastName = " Parthasarathy" };
            var operation = new Operations();
            ProcessHandler abc = new ProcessHandler();
            ProcessHandler.myHandler process = operation.JoinStrings;
            process += operation.RemoveWhiteSpace;
            process += operation.FindCharacter;
            process += operation.Reverse;

            abc.CallHandler(text, process);

            
        }
    
    }

    class Letter
    {
        public string text { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
    
    class ProcessHandler
    {
        public void CallHandler(Letter letter, myHandler handler)
        {
            handler(letter);
        }

        public delegate void myHandler(Letter letter);
    }
    class Operations
    {
        public void RemoveWhiteSpace(Letter letter)
        {
            var remove = letter.text.Replace(" ", "_");
            Console.WriteLine("After removing the whitespace the string is : " + remove);
        }

        public void JoinStrings(Letter letter)
        {
            var join = letter.firstName + letter.lastName;
            Console.WriteLine("The full name is : " + join);
        }

        public void Reverse(Letter letter)
        {
            int len = letter.text.Length - 1;
            string rev = "";
            while (len >= 0)
            {
                rev = rev + letter.text[len];
                len--;
            }
            Console.WriteLine("The reverse of the given string is - " + rev);
        }

        public void FindCharacter(Letter letter)
        {
            var chr = letter.text.Contains('e');
            Console.WriteLine("The character is found");
        }

    }


    }

