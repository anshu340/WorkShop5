using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    internal class Bike : Vehicles
    {
        // Implement abstract method StartEngine
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started with a kick.");
        }

        // Implement abstract method StopEngine
        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }
}
