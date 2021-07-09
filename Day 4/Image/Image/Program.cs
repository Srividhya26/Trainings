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
