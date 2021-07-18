using System;

namespace MethodHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Base();
            obj1.WriteNum();
            obj1.WriteStr();
            var obj3 = new Derived();
            obj3.WriteNum();
            obj3.WriteStr();
            var obj2 = (Derived) obj1;
            obj2.WriteNum();
            obj2.WriteStr();    
        }
    }
}
