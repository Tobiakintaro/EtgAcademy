using System;
using System.Collections.Generic;
using System.Text;

namespace EtgAcademy2026.Models
{
    public static class Vehicle
    {


        public static void DisplayVehicleInfo()
        {
            var car = new Car();
            car.Make = "Toyota";
            car.Model = "Camry";
            car.Year = 2020;
            car.FuelType = "Gasoline";
            var motorcycle = new Motorcycle();
            motorcycle.Make = "Honda";
            motorcycle.Model = "CBR500R";
            motorcycle.Year = 2021;
            motorcycle.EngineCapacity = 500;
            Console.WriteLine("Car Information:");
            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");
            Console.WriteLine($"Fuel Type: {car.FuelType}");
            Console.WriteLine("\nMotorcycle Information:");
            Console.WriteLine($"Make: {motorcycle.Make}");
            Console.WriteLine($"Model: {motorcycle.Model}");
            Console.WriteLine($"Year: {motorcycle.Year}");
            Console.WriteLine($"Engine Capacity: {motorcycle.EngineCapacity} cc");
        }






    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string FuelType { get; set; }
    }

    public class Motorcycle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int EngineCapacity { get; set; }
    }

}
