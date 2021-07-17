using System;

namespace AssetManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Asset assets;
            assets = new Computer();
            assets.Configuration("8GB","1600*900");
            assets = new Laptop();
            assets.Configuration("4GB","5.6' inch");
            assets = new HeadPhone();
            assets.Configuration("Redmi","wireless");
            assets = new Mouse();
            assets.Configuration("HP","wired");
            assets = new DockStation();
            assets.Configuration("USB 3.0 port","Lenova");
            assets.Warranty();
        }
    }
}
