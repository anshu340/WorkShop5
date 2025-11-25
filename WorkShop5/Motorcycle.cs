using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    class Motorcycle : Vehicle
    {
        // Unique field for Motorcycle
        public bool HasSidecar { get; set; }

        // Constructor
        public Motorcycle(string brand, int speed, bool hasSidecar) : base(brand, speed)
        {
            HasSidecar = hasSidecar;
        }

        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine("Motorcycle Information ");
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
        }
    }
}