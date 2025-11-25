using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    // 1. Abstract class Vehicles
    abstract class Vehicles
    {
        // Abstract methods - must be implemented by derived classes
        public abstract void StartEngine();
        public abstract void StopEngine();

        // Concrete method - has implementation
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
