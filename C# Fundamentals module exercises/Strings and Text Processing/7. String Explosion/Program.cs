using System;

namespace _7._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            int p = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];
                if (input[i] == '>')
                {
                    int power = int.Parse(input[i + 1].ToString()) + p;
                    while(power>0)
                    {
                        i++;
                        if (i == input.Length) break;
                        if (input[i] == '>')
                        {
                            i--;
                            break;
                        }
                        power--;
                    }
                    p += power;
                }
            }
            Console.WriteLine(result);
        }
    }
}
