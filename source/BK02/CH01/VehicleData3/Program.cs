using System;

namespace VehicleData2
{
    class Program
    {
        public class Motor
        {
            public int power;             // Power [horsepower]
            public double displacement;   // Engine displacement [liter]
        }

        public class Vehicle
        {
            public string model { get; set; }         // Name of the model
            public string manufacturer { get; set; }  // Name of the manufacturer
            public int numOfDoors { get; set; }       // Number of vehicle doors
            public int numOfWheels { get; set; }      // You get the idea.
            public Motor motor { get; set; }          // Type of engine.
        }

        static void Main(string[] args)
        {
            // Create an instance of Vehicle.
            Vehicle myCar = new()
            {
                model = "Cherokee Sport",
                manufacturer = "Jeep",
                numOfDoors = 2,
                numOfWheels = 4,
                motor = new()
                {
                    power = 230,
                    displacement = 4.0
                }
            };

            // Now display the results.
            Console.WriteLine($"\nYour vehicle is a {myCar.manufacturer} " +
                $"{myCar.model} with {myCar.numOfDoors} doors riding on " +
                $"{myCar.numOfWheels} wheels using a {myCar.motor.displacement}" +
                $" liter engine producing {myCar.motor.power} hp.");

            Console.Read();
        }
    }
}
