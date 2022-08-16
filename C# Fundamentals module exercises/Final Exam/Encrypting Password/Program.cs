using System;

namespace Encrypting_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPass = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPass; i++)
            {
                string input = Console.ReadLine();
                PassCheck(input);
            }
        }

        private static void PassCheck(string input)
        {
            if (input.Contains(">") && input.Contains("<") && input.IndexOf(">") < input.IndexOf("<"))
            {
                string start = input.Substring(0, input.IndexOf(">"));
                string end = input.Substring(input.LastIndexOf("<") + 1);
                if (start == end)
                {
                    bool isSymbol = true;
                    for (int i = 0; i < start.Length; i++)
                    {
                        if (!char.IsSymbol(start[i]))
                        {
                            isSymbol = false;
                            break;
                        }
                    }
                    if (isSymbol)
                    {
                        string pass = input.Substring(input.IndexOf(">") + 1, input.LastIndexOf("<") - input.IndexOf(">") - 1);
                        string firstGroup = pass.Substring(0, pass.IndexOf("|"));
                        bool firstGroupCheck = true;
                        for (int i = 0; i < firstGroup.Length; i++)
                        {
                            if (!char.IsDigit(firstGroup[i]))
                            {
                                firstGroupCheck = false;
                                break;
                            }
                        }
                        if (firstGroupCheck)
                        {
                            string secondAndThirdGroup = pass.Substring(pass.IndexOf("|") + 1, pass.LastIndexOf("|") - pass.IndexOf("|") - 1);
                            string secondGroup = secondAndThirdGroup.Substring(0, secondAndThirdGroup.IndexOf("|"));
                            string thirdGroup = secondAndThirdGroup.Substring(secondAndThirdGroup.IndexOf("|") + 1);
                            string fourthGroup = pass.Substring(pass.IndexOf("|") + 1);
                            bool secondGroupCheck = true, thirdGroupCheck = true, fourthGroupCheck = true;
                            for (int i = 0; i < secondGroup.Length; i++)
                            {
                                if (!char.IsLower(secondGroup[i]))
                                {
                                    secondGroupCheck = false;
                                    break;
                                }
                            }
                            if (secondGroupCheck)
                            {
                                for (int i = 0; i < thirdGroup.Length; i++)
                                {
                                    if (char.IsLower(thirdGroup[i]))
                                    {
                                        thirdGroupCheck = false;
                                        break;
                                    }
                                }
                                if (thirdGroupCheck)
                                {
                                    for (int i = 0; i < fourthGroup.Length; i++)
                                    {
                                        if (!char.IsSymbol(fourthGroup[i]) || fourthGroup[i] == '>' || fourthGroup[i] == '<')
                                        {
                                            fourthGroupCheck = false;
                                            break;
                                        }
                                    }
                                    if (fourthGroupCheck)
                                    {
                                        Console.WriteLine($"Password: {firstGroup + secondGroup + thirdGroup + fourthGroup}");
                                    }
                                    else Console.WriteLine("Try another password!");
                                }
                                else Console.WriteLine("Try another password!");
                            }
                            else Console.WriteLine("Try another password!");
                        }
                        else Console.WriteLine("Try another password!");
                    }
                    else Console.WriteLine("Try another password!");
                }
                else Console.WriteLine("Try another password!");
            }
            else Console.WriteLine("Try another password!");
        }
    }
}
