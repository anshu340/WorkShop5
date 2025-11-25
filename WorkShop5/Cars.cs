using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    internal class Cars : Vehicles
    {// Implement abstract method StartEngine
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started with a key.");
        }

        // Implement abstract method StopEngine
        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }
}