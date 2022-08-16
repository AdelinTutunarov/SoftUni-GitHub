using System;

namespace Decrypting_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "Finish")
            {
                switch (command[0])
                {
                    case "Replace":
                        myString = myString.Replace(command[1], command[2]);
                        Console.WriteLine(myString);
                        break;
                    case "Cut":
                        if(int.Parse(command[1])>=0 && int.Parse(command[1])<myString.Length && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < myString.Length)
                        {
                            myString = myString.Remove(int.Parse(command[1]) + 1, int.Parse(command[2]) - int.Parse(command[1]) + 1);
                            Console.WriteLine(myString);
                        }
                        else Console.WriteLine("Invalid indices!");
                        break;
                    case "Make":
                        switch (command[1])
                        {
                            case "Upper":
                                myString = myString.ToUpper();
                                Console.WriteLine(myString);
                                break;
                            case "Lower":
                                myString = myString.ToLower();
                                Console.WriteLine(myString);
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Check":
                        if (myString.Contains(command[1])) Console.WriteLine($"Message contains {command[1]}");
                        else Console.WriteLine($"Message doesn't contain {command[1]}");
                        break;
                    case "Sum":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < myString.Length && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < myString.Length)
                        {
                            Sum(myString, int.Parse(command[1]), int.Parse(command[2]));
                        }
                        else Console.WriteLine("Invalid indices!");
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }
        }

        private static void Sum(string myString, int startIndex, int endIndex)
        {
            char[] mySubstring = myString.Substring(startIndex, endIndex - startIndex + 1).ToCharArray();
            int sum = 0;
            for (int i = 0; i < mySubstring.Length; i++)
            {
                sum += mySubstring[i];
            }
            Console.WriteLine(sum);
        }
    }
}
