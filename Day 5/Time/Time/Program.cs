using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var minValue = DateTime.MinValue.ToString("HH:mm");
                var maxValue = DateTime.MaxValue.ToString("HH:mm");
                Console.WriteLine("Enter the time in 24hrs format");
                var time = Convert.ToDateTime(Console.ReadLine());
                if (time >= DateTime.MinValue && time <= DateTime.MaxValue)
                    Console.WriteLine("Valid Time");
            }

            catch
            {
                Console.WriteLine("Invalid Time");
            }
            
            
        }
    }
}
