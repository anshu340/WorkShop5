namespace WorkShop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Task 1

            // Create BankAccount object
            BankAccount account = new BankAccount("ACC12345", 5000);

            // Display account number
            Console.WriteLine("Account Number: " + account.AccountNumber);

            // Deposit money
            account.Deposit(2000);

            // Withdraw money
            account.Withdraw(1500);

            // Print remaining balance
            Console.WriteLine("Remaining Balance: " + account.Balance);

            // Task 2

            // Create objects of both derived classes
            Car myCar = new Car("Toyota", 180, 5);
            Motorcycle myMotorcycle = new Motorcycle("Harley-Davidson", 200, false);

            // Demonstrate Car methods
            Console.WriteLine("Testing Car");
            myCar.Start();
            myCar.DisplayInfo();
            myCar.Stop();

            Console.WriteLine("\nTesting Motorcycle ");
            myMotorcycle.Start();
            myMotorcycle.DisplayInfo();
            myMotorcycle.Stop();

            // Demonstrate polymorphism - code reusability
            Console.WriteLine("\n Demonstrating Polymorphism ");
            Vehicle[] vehicles = { myCar, myMotorcycle };

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine();
                vehicle.Start();
                vehicle.DisplayInfo();
                vehicle.Stop();
            }

            // Task 3

            Printer printer = new Printer();

            printer.Print("Hi Polymorphism");
            printer.Print(123);
            printer.Print("Repeat Message", 3);

            Console.ReadLine();


        }
    }
}
