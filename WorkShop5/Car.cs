using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    class Car : Vehicle
    {
        // Unique field for Car
        public int Seats { get; set; }

        // Constructor
        public Car(string brand, int speed, int seats) : base(brand, speed)
        {
            Seats = seats;
        }

        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine(" Car Information ");
            base.DisplayInfo();
            Console.WriteLine($"Seats: {Seats}");
        }
    }
}
