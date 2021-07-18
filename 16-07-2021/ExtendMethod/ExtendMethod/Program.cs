using System;

namespace ExtendMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var ins = new Insurance();
            ins.Name = "Shobana";
            ins.email = "shobana@gmail.com";
            ins.Email = ins.email;
            ins.aadhaarno = "3675 9834 6015";
            ins.AadhaarcardNo = ins.aadhaarno;
            Console.WriteLine("Name : " + ins.name);
            Console.WriteLine("Email : " + ins.Email);
            Console.WriteLine("Aadhaar No : "+ins.AadhaarcardNo);
            ins.GetDueDate();
        }
    }
}
