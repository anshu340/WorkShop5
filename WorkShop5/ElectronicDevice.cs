using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    // Abstract Class ElectronicDevice
    abstract class ElectronicDevice
    {
        // Private fields
        private string brand;
        private double price;

        // Public properties (Encapsulation)
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // Constructor to initialize Brand and Price
        public ElectronicDevice(string brand, double price)
        {
            this.brand = brand;
            this.price = price;
        }

        // Abstract method - must be implemented by derived classes
        public abstract void ShowInfo();
    }
}