using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" ");
            double carCount = 0, truckCount = 0, carsHP = 0, trucksHP = 0;
            var vehicles = new List<Vehicle>();
            while (command[0] != "End")
            {
                var vehicle = new Vehicle(command[0], command[1], command[2], int.Parse(command[3]));
                vehicles.Add(vehicle);
                if(vehicle.Type == "car")
                {
                    carCount++;
                    carsHP += vehicle.Horsepower;
                    vehicle.Type = "Car";
                }else if(vehicle.Type == "truck")
                {
                    truckCount++;
                    trucksHP += vehicle.Horsepower;
                    vehicle.Type = "Truck";
                }
                command = Console.ReadLine().Split(" ");
            }
            command = Console.ReadLine().Split(" ");
            while (string.Join(" ", command) != "Close the Catalogue")
            {
                foreach (var v in vehicles)
                {
                    if (v.Model == command[0]) v.print();
                }
                command = Console.ReadLine().Split(" ");
            }
            Console.WriteLine($"Cars have average horsepower of: {carsHP/carCount:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksHP/truckCount:f2}.");
        }
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string type, string model, string color, int hp)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = hp;
        }

        public void print()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Horsepower: {Horsepower}");
        }
    }
}
