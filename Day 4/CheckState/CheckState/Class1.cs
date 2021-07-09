using System;

namespace Day4_Assign
{
    class Class1
    {
        public string CheckState()
        {
            string countryName, stateName;
            Console.WriteLine("Enter a country name");
            countryName = Console.ReadLine();
            Console.WriteLine("Enter the state name");
            stateName = Console.ReadLine();
            if (countryName == "india" || countryName == "INDIA")
            {
                if (stateName == "kerala")
                {
                    return "true";
                }
            }
            else
            {
                return "false";
            }
            
            return " ";
        }

        public static void Main(string[] args)
        {
            string value;
            Class1 obj = new Class1();
            value = obj.CheckState();
            Console.WriteLine(value); 
            
        }
    }
}

