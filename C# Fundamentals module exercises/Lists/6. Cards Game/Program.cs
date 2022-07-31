using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (player1.Any() && player2.Any())
            {
                for (int i = 0; i < player1.Count && i < player2.Count; i++)
                {
                    if (player1[i] > player2[i])
                    {
                        player1.Add(player2[i]);
                        player1.Add(player1[i]);
                        player1.RemoveAt(i);
                        player2.RemoveAt(i);
                    }
                    else if (player1[i] < player2[i])
                    {
                        player2.Add(player1[i]);
                        player2.Add(player2[i]);
                        player2.RemoveAt(i);
                        player1.RemoveAt(i);
                    }
                    else
                    {
                        player1.RemoveAt(i);
                        player2.RemoveAt(i);
                    }
                }
            }
            if (player1.Any())
            {
                int sum = winner(player1);
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = winner(player2);
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }

        private static int winner(List<int> player)
        {
            int sum = 0;
            foreach (int i in player)
            {
                sum += i;
            }
            return sum;
        }
    }
}
