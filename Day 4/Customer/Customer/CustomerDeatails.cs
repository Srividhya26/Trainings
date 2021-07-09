using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class CustomerDeatails
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PlaceOrder()
        {
            return "mobile phone";
        }
        public static string GetCustomerTimezone()
        {
            return "GMT+5.30";
        }
    }
}
