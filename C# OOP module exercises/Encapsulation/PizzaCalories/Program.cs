using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] doughInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            try
            {
                Dough dough = new Dough(doughInput[1], doughInput[2], double.Parse(doughInput[3]));
                Pizza pizza = new Pizza(dough, pizzaInput[1]);
                while (true)
                {
                    string stringToppingInput = Console.ReadLine();
                    if (stringToppingInput == "END") break;
                    string[] toppingInput = stringToppingInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Topping topping = new Topping(toppingInput[1], double.Parse(toppingInput[2]));
                    pizza.AddTopping(topping);
                }
                Console.WriteLine(pizza);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
