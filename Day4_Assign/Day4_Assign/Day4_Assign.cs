//Duplicate arrays
using System;
using System.Collections;


//Duplicate arrays

namespace Day4_Assign
{
    public class Array
    {
        public static void Main(string[] args) 
        {
            int[] arr = new int[10];// { 3, 5, 9, 2, 3, 9, 5, 1, 8, 7 };
            Console.WriteLine("Enter the array values");
            for (int n = 0; n < 10 ;n++)
            {
               arr[n] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The duplicate arrays in a list");
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[j]);
                }
            }
            



        }
    }
}

//Image Resolution Program

using System;

namespace Image
{
    class Program
    {
        enum Landscape
        {
            width = 1920,height=1080
        }

        enum Portrait
        {
            width = 1080,height=1920
        }
        static void Main(string[] args)
        {
            int width, height;
            Console.WriteLine("Enter the width");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height");
            height = Convert.ToInt32(Console.ReadLine());
            var x = (int)Portrait.width == 1080 && (int)Portrait.height == 1920 ? "It is portrait mode" : (int)Landscape.width == 1920 && (int)Landscape.height == 1080 ? "It is landscape mode" : "Enter a valid width and height";
            Console.WriteLine(x);
        } 
    }
}

//State and country program

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

