using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    internal class Printer
    {

        public void Print(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        // 2. Print integer number
        public void Print(int number)
        {
            Console.WriteLine("Number: " + number);
        }

        // 3. Print message multiple times
        public void Print(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"[{i + 1}] {message}");
            }
        }

    }
}
