using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    internal class Smartphone : ElectronicDevice
    {
        // Constructor
        public Smartphone(string brand, double price) : base(brand, price)
        {
        }

        // Extra method specific to Smartphone
        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera is now enabled.");
        }

        // Override the abstract method
        public override void ShowInfo()
        {
            Console.WriteLine("Smartphone Details");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price: ${Price}");
        }
    }
}
