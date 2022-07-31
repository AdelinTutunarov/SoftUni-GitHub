using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            var people = new List<Person>();
            while (command[0] != "End")
            {
                var person = new Person(command[0], command[1], int.Parse(command[2]));
                people.Add(person);
                command = Console.ReadLine().Split();
            }
            people.OrderBy(person => person.Age).ToList().ForEach(person => Console.WriteLine(person));
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
