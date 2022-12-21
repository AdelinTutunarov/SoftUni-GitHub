using System;
using System.Collections.Generic;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            while (songs.Count >= 0)
            {
                string[] cmd = Console.ReadLine().Split();
                string song = "";
                for (int i = 1; i < cmd.Length; i++)
                {
                    if (i == cmd.Length - 1) song += $"{cmd[i]}";
                    else song += $"{cmd[i]} ";
                }
                switch (cmd[0])
                {
                    case "Play":
                        if (songs.Count > 1) songs.Dequeue();
                        else
                        {
                            Console.WriteLine("No more songs!");
                            return;
                        }
                        break;
                    case "Add":
                        if (songs.Contains(song)) Console.WriteLine($"{song} is already contained!");
                        else songs.Enqueue(song);
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
