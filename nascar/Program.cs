using System;

namespace nascar
{
    // Interface representing a NASCAR driver
    interface INascarDriver
    {
        // Properties
        string Name { get; }
        int CarNumber { get; }
        string Team { get; }
        string Manufacturer { get; }

        // Method to display driver information
        void DisplayInfo();
    }

    // Concrete class representing a NASCAR driver
    class NascarDriver : INascarDriver
    {
        // Properties
        public string Name { get; }
        public int CarNumber { get; }
        public string Team { get; }
        public string Manufacturer { get; }

        // Constructor
        public NascarDriver(string name, int carNumber, string team, string manufacturer)
        {
            Name = name;
            CarNumber = carNumber;
            Team = team;
            Manufacturer = manufacturer;
        }

        // Implementing the DisplayInfo method
        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} is driving the #{CarNumber} {Team} {Manufacturer}.");
            Console.WriteLine($"{Name} is the driver, {CarNumber} is his number, {Team} is the team he is a member of, and {Manufacturer} is his team's manufacturer.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a NASCAR driver object
            INascarDriver driver = new NascarDriver("Denny Hamlin", 11, "Joe Gibbs Racing", "Toyota Camry");

            // Display driver information
            driver.DisplayInfo();
        }
    }
}