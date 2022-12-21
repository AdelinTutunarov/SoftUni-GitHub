using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Beast!") break;
                else
                {
                    string[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    switch (input)
                    {
                        case "Dog":
                            Dog dog = new Dog(input2[0], int.Parse(input2[1]), input2[2]);
                            Console.WriteLine("Dog");
                            Console.WriteLine(dog);
                            dog.ProduceSound();
                            break;
                        case "Cat":
                            Cat cat = new Cat(input2[0], int.Parse(input2[1]), input2[2]);
                            Console.WriteLine("Cat");
                            Console.WriteLine(cat);
                            cat.ProduceSound();
                            break;
                        case "Frog":
                            Frog frog = new Frog(input2[0], int.Parse(input2[1]), input2[2]);
                            Console.WriteLine("Frog");
                            Console.WriteLine(frog);
                            frog.ProduceSound();
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(input2[0], int.Parse(input2[1]));
                            Console.WriteLine("Kitten");
                            Console.WriteLine(kitten);
                            kitten.ProduceSound();
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(input2[0], int.Parse(input2[1]));
                            Console.WriteLine("Tomcat");
                            Console.WriteLine(tomcat);
                            tomcat.ProduceSound();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
