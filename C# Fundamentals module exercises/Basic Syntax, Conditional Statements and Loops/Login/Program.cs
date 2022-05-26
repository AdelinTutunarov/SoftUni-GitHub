using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(), input;
            char[] pass = name.ToCharArray(), h;
            Array.Reverse(pass);
            bool p = true; int counter = 0;
            do
            {
                input = Console.ReadLine();
                h = input.ToCharArray();
                for (int i = 0; i < h.Length; i++)
                {
                    if (h[i] != pass[i])
                    {
                        p = false;
                        break;
                    }
                }

                if (p)
                {
                    if (p) Console.WriteLine($"User {name} logged in.");
                    break;
                }
                else
                {
                    counter += 1;
                    if (counter == 4) break;
                    Console.WriteLine("Incorrect password. Try again.");
                    p = true;
                }
            } while (true);
            if (!p) Console.WriteLine($"User {name} blocked!");
        }
    }
}
