using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = CreateEngine(input);
                engines.Add(input[0], engine);
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = CreateCar(input,engines);
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
        public static Engine CreateEngine(string[] input)
        {
            Engine engine = new Engine(input[0], int.Parse(input[1]));
            if (input.Length > 2)
            {
                int displacement;
                bool IsDigit = int.TryParse(input[2], out displacement);
                if (IsDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = input[2];
                }

                if (input.Length > 3)
                {
                    engine.Efficiency = input[3];
                }
            }
            return engine;
        }
        public static Car CreateCar(string[] input, Dictionary<string, Engine> engines)
        {
            Car car = new Car(input[0], engines[input[1]]);
            if (input.Length > 2)
            {
                int weight;
                var isDigit = int.TryParse(input[2], out weight);
                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = input[2];
                }
                if (input.Length > 3)
                {
                    car.Color = input[3];
                }
            }
            return car;
        }
    }
}
