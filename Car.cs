using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car
    {
        // Fields
        private string brand;
        private string model;
        private int year;
        private decimal price;

        // Constructor with parameters
        public Car(string brand, string model, int year, decimal price)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        // Constrictor without parameters 
        public Car()
        {
            brand = null;
            model = null;
            year = 0;
            price = 0;
        }

        // Method to display car information
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}, Price: {price:C}");
        }

        // Properties
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
