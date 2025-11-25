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
            Console.WriteLine();

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

            Console.WriteLine();

            // Task 3

            Printer printer = new Printer();

            printer.Print("Hi Polymorphism");
            printer.Print(123);
            printer.Print("Repeat Message", 3);


            NepaliTeacher nepaliTeacher = new NepaliTeacher();
            nepaliTeacher.Name = "Anshu Karki";
            Console.WriteLine("Name: " + nepaliTeacher.Name);
            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();
            Console.WriteLine();

            EnglishTeacher englishTeacher = new EnglishTeacher();
            englishTeacher.Name = "Abishek Karki";
            Console.WriteLine("Name: " + englishTeacher.Name);
            englishTeacher.Teaching();  // Uses base class method
            englishTeacher.SalaryInfo();

            Console.WriteLine();

            // Task 4

            // Create objects of both derived classes
            Cars Car = new Cars();
            Bike myBike = new Bike();

            // Test Car object
            Console.WriteLine("Testing Car");
            Car.Display();  // Calls concrete method from base class
            Car.StartEngine();  // Calls overridden method
            Car.StopEngine();  // Calls overridden method

            Console.WriteLine();

            // Test Bike object
            Console.WriteLine("Testing Bike ");
            myBike.Display();   // Calls concrete method from base class
            myBike.StartEngine(); // Calls overridden method
            myBike.StopEngine();  // Calls overridden method

            Console.WriteLine("");

            // Task 5




            Console.WriteLine("");
        }
    }
}
