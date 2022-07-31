using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split().ToArray();
            List<string> chat = new List<string>();
            while(command[0] != "end")
            {
                switch (command[0])
                {
                    case "Chat":
                        chat.Add(command[1]);
                        break;
                    case "Delete":
                        if (chat.Contains(command[1])) chat.Remove(command[1]);
                        break;
                    case "Edit":
                        if (chat.Contains(command[1]))
                        {
                            chat[chat.IndexOf(command[1])] = command[2];
                        }
                        break;
                    case "Pin":
                        if (chat.Contains(command[1]))
                        {
                            chat.Remove(command[1]);
                            chat.Add(command[1]);
                        }
                        break;
                    case "Spam":
                        for (int i = 1; i < command.Length; i++)
                        {
                            chat.Add(command[i]);
                        }
                        break;
                }
                command = Console.ReadLine().Split().ToArray();
            }
            foreach(string message in chat)
            {
                Console.WriteLine(message);
            }
        }
    }
}
