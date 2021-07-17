using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement
{
    public abstract class Asset
    {
        public abstract void Configuration(string memory,string display);
        public void Warranty()
        {
            Console.WriteLine("The Warrenty of all the product is 3 years");
        }
        
    }

    class Computer : Asset
    {
        public override void Configuration(string memory,string display)
        {
            Console.WriteLine($"Computer : The Memory of the computer is {memory} and Display is {display}");
        }
    }

    class Laptop : Asset
    {
        public override void Configuration(string memory,string display){
            Console.WriteLine($"Laptop : The Memory of the Laptop is {memory} and  Display is {display} ");
        }

    }

    class HeadPhone : Asset
    {
        public override void Configuration(string company,string type)
        {
            Console.WriteLine($"Headphone : The company name is {company} and the type is {type}");
        }
    }

    class Mouse : Asset
    {
        public override void Configuration(string company,string type)
        {
            Console.WriteLine($"Mouse : The company name is {company} and the type is {type}");
        }
    }

    class DockStation : Asset
    {
        public override void Configuration(string port,string company)
        {
            Console.WriteLine($"Dockstation : The port of the Dockstation is {port} and company is {company}");
        }
        
    }
}
