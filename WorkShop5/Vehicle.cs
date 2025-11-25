using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    internal class Vehicle
    {

        // Properties
        public string Brand { get; set; }
        public int Speed { get; set; }

        // Constructor
        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        // Methods
        public void Start()
        {
            Console.WriteLine($"{Brand} is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping...");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
        }
    }
}
