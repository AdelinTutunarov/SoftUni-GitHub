using System;
using System.Collections.Generic;

namespace _4._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            int numberOfCmds = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCmds; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0] == "register")
                {
                    if (users.ContainsKey(cmd[1])) Console.WriteLine($"ERROR: already registered with plate number {cmd[2]}");
                    else
                    {
                        users[cmd[1]] = cmd[2];
                        Console.WriteLine($"{cmd[1]} registered {cmd[2]} successfully");
                    }
                }
                else if (cmd[0] == "unregister")
                {
                    if (users.ContainsKey(cmd[1]))
                    {
                        users.Remove(cmd[1]);
                        Console.WriteLine($"{cmd[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {cmd[1]} not found");
                    }
                }
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
