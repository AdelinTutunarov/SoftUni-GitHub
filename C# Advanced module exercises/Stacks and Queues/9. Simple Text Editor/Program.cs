using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> memory = new Stack<string>();
            memory.Push("");
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                switch (cmd[0])
                {
                    case "1":
                        text.Append(cmd[1]);
                        memory.Push(text.ToString());
                        break;
                    case "2":
                        text = text.Remove(text.Length - int.Parse(cmd[1]), int.Parse(cmd[1]));
                        memory.Push(text.ToString());
                        break;
                    case "3":
                        if (int.Parse(cmd[1]) > 0 && int.Parse(cmd[1]) <= text.Length)
                            Console.WriteLine(text[int.Parse(cmd[1]) - 1]);
                        break;
                    case "4":
                        memory.Pop();
                        text = new StringBuilder(memory.Peek());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
