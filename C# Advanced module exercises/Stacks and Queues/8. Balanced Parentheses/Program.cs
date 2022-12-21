using System;
using System.Collections.Generic;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            if (stack.Count % 2 == 0)
            {
                Stack<char> anotherStack = new Stack<char>();
                while (stack.Count > 0)
                {
                    if(stack.Peek()==')' || stack.Peek() == '}' || stack.Peek() == ']')
                    {
                        anotherStack.Push(stack.Pop());
                    }
                    else
                    {
                        switch (stack.Peek())
                        {
                            case '(':
                                if (anotherStack.Peek() == ')')
                                {
                                    anotherStack.Pop();
                                    stack.Pop();
                                }
                                else
                                {
                                    Console.WriteLine("NO");
                                    return;
                                }
                                break;
                            case '[':
                                if (anotherStack.Peek() == ']')
                                {
                                    anotherStack.Pop();
                                    stack.Pop();
                                }
                                else
                                {
                                    Console.WriteLine("NO");
                                    return;
                                }
                                break;
                            case '{':
                                if (anotherStack.Peek() == '}')
                                {
                                    anotherStack.Pop();
                                    stack.Pop();
                                }
                                else
                                {
                                    Console.WriteLine("NO");
                                    return;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
        }
    }
}
