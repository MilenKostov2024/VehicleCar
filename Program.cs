using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first car object
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Model = "Camry";
            car1.Year = 2020;
            car1.Price = 24000.00m;

            // Create second car object
            Car car2 = new Car();
            car2.Brand = "Honda";
            car2.Model = "Accord"; 
            car2.Year = 2019;
            car2.Price = 22000.00m;

            // Display car information
            car1.DisplayInfo();
            car2.DisplayInfo();

            // Wait for user input before closing
            Console.ReadLine();
        }
    }
}
