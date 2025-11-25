using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    internal class Teacher
    {
        public string Name { get; set; }

        // Virtual so it can be overridden
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Method that cannot be overridden → sealed (inside a non-virtual method)
        public void SalaryInfo()
        {
            Console.WriteLine("Salary cannot be modified by child classes.");
        }
    }
}
