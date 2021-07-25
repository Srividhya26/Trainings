using System;

namespace Events
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var handler = new StringArgs();
            var operations = new Operator();
            handler.OnEventHandler += operations.RemoveWhiteSpace;
            handler.OnEventHandler += operations.JoinStrings;
            handler.OnEventHandler += operations.FindCharacter;
            handler.OnEventHandler += operations.Reverse;

            handler.Process();
        }

       
    }

    public class StringArgs : EventArgs // creating custom events
    {
        public string Text;
        public string FirstName;
        public string LastName;

        public StringArgs()
        {

        }
        public StringArgs(string text, string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Text = text;
        }

        public delegate void StringHandler(object source, StringArgs args);
        
        public event StringHandler OnEventHandler;


        public void OnEventProcess()
        {
            if (OnEventHandler != null)
            {
                StringArgs args = new StringArgs
                    (
                    "A programming language is a vocabulary and set of grammatical rules for instructing a computer or computing device to perform specific tasks.",
                    "John", 
                    "Thomas"
                    );
                OnEventHandler(this, args);
            }
        }

        public void Process()
        {
            OnEventProcess();
        }
    }

        class Operator
        { 

            public void JoinStrings(object source, StringArgs args)
            {
                var join = args.FirstName + " " + args.LastName;
                Console.WriteLine("The full name is : " + join);
            }

            public void RemoveWhiteSpace(object source, StringArgs args)
            {
                var remove = args.Text.Replace(" ", "_");
                Console.WriteLine("After removing the whitespace the string is : " + remove);
            }

            public void Reverse(object source, StringArgs args)
            {
                int len = args.Text.Length - 1;
                string rev = "";
                while (len >= 0)
                {
                    rev = rev + args.Text[len];
                    len--;
                }
                Console.WriteLine("The reverse of the given string is - " + rev);
            }

            public void FindCharacter(object source, StringArgs args)
            {
                var chr = args.Text.Contains('e');
                if (chr == true)
                {
                    Console.WriteLine("The character is found");
                }
                else
                {
                    Console.WriteLine("Character is not found in the given text");
                }

            }

        }
    }
    

    
    




    
        
            
    


    


