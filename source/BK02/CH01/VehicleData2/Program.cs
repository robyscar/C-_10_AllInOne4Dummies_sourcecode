using System;

namespace VehicleData2
{
    class Program
    {
        public class Vehicle
        {
            public string model { get; set; }         // Name of the model
            public string manufacturer { get; set; }  // Name of the manufacturer
            public int numOfDoors { get; set; }       // Number of vehicle doors
            public int numOfWheels { get; set; }      // You get the idea.
        }

        static void Main(string[] args)
        {
            // Prompt user to enter a name.
            Console.WriteLine("Enter the properties of your vehicle");

            // Obtain the data needed to create myCar.
            Console.Write("Model name = ");
            string s = Console.ReadLine();

            Console.Write("Manufacturer name = ");
            string mfg = Console.ReadLine();

            Console.Write("Number of doors = ");
            int doors = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of wheels = ");
            int wheels = Convert.ToInt32(Console.ReadLine());

            // Create an instance of Vehicle.
            Vehicle myCar = new()
            {
                model = s,
                manufacturer = mfg,
                numOfDoors = doors,
                numOfWheels = wheels
            };

            // Now display the results.
            Console.WriteLine($"\nYour vehicle is a {myCar.manufacturer} " +
                $"{myCar.model} with {myCar.numOfDoors} doors riding on " +
                $"{myCar.numOfWheels} wheels");


            Console.Read();
        }
    }
}
