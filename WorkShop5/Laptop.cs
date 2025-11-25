using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    internal class Laptop : ElectronicDevice
    {
        // Constructor
        public Laptop(string brand, double price) : base(brand, price)
        {
        }

        // Extra method specific to Laptop
        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery is now turned on.");
        }

        // Override the abstract method
        public override void ShowInfo()
        {
            Console.WriteLine(" Laptop Details ");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price: ${Price}");
        }
    }
}
