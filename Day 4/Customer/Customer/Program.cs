using System;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new Lazy<CustomerDeatails>();
            var cus = new CustomerDeatails();
            cus.CustomerId = 1010;
            cus.CustomerName = "Vidhya";

            var order = cus.PlaceOrder();
            var timeZone = Customer.CustomerDeatails.GetCustomerTimezone();
            Console.WriteLine($"{order} {timeZone}");

        }
    }
}
