using System;

namespace DMS
{
    class Program
    {
        public void DMS(decimal value)
        {

            decimal degree = Convert.ToInt32(Math.Floor(value));
            decimal min = (value - Math.Floor(value)) * 60;
            decimal sec = (min - Math.Floor(min)) * 60;
            min = Math.Floor(min);
            sec = Math.Round(sec);
            Console.WriteLine($"{degree} degrees , {min} minutes and {sec} seconds");
        }

        static void Main(string[] args)
        {
            Program obj1 = new Program();
            obj1.DMS(183.564m);
        }
        
    }
}
