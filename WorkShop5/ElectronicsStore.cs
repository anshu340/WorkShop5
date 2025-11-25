using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    internal class ElectronicsStore
    {

        // List to maintain ElectronicDevice objects
        private List<ElectronicDevice> devices;

        // Constructor
        public ElectronicsStore()
        {
            devices = new List<ElectronicDevice>();
        }

        // Method to add a device to the store
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"Device added to store: {device.Brand}");
        }

        // Method to remove a device from the store
        public void RemoveDevice(ElectronicDevice device)
        {
            if (devices.Remove(device))
            {
                Console.WriteLine($"Device removed from store: {device.Brand}");
            }
            else
            {
                Console.WriteLine("Device not found in store.");
            }
        }
        // Method to display information of all devices in the store
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("     ELECTRONICS STORE INVENTORY");

            if (devices.Count == 0)
            {
                Console.WriteLine("No devices in store.");
                return;
            }

            for (int i = 0; i < devices.Count; i++)
            {
                Console.WriteLine($"\nDevice #{i + 1}:");
                devices[i].ShowInfo(); // Call ShowInfo() for each device

                // Downcast and call child-specific methods
                if (devices[i] is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (devices[i] is Smartphone smartphone)
                {
                    smartphone.EnableCamera();
                }
            }

            Console.WriteLine(" ");


        }
    }
}