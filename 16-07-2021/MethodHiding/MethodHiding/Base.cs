using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class Base
    {
        public void WriteNum()
        {
            int id = 101;
            Console.WriteLine("ID : " + id);
        }

        public virtual void WriteStr()
        {
            string emp1 = "John";
            Console.WriteLine("Name : " + emp1);
        }
    }

    class Derived : Base
    {
        public new void WriteNum()
        {
            int id = 302;
            Console.WriteLine("ID : " + id);
        }

        public override void WriteStr()
        {
            string emp2 = "Janani";
            Console.WriteLine("The name of the employee is " + emp2);
        }
    }
}
