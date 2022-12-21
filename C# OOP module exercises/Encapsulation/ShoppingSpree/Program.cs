using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] peopleInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Product> products = new List<Product>();
            try
            {
                foreach (var stringPerson in peopleInput)
                {
                    string[] arrPerson = stringPerson.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    Person person = new Person(arrPerson[0], double.Parse(arrPerson[1]));
                    people.Add(person);
                }
                foreach (var stringProduct in productsInput)
                {
                    string[] arrProduct = stringProduct.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    Product product = new Product(arrProduct[0], double.Parse(arrProduct[1]));
                    products.Add(product);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] cmd = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var person in people)
                {
                    if (cmd[0] == person.Name)
                    {
                        foreach (var product in products)
                        {
                            if (cmd[1] == product.Name)
                            {
                                person.Buy(product);
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

        }
    }
}
