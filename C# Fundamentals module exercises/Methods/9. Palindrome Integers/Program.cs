using System;
using System.Collections.Generic;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Queue<bool> checkedNumbers = new Queue<bool>();
            input(n, checkedNumbers);
            output(checkedNumbers);
        }

        static void input(string n, Queue<bool> q)
        {
            while(n != "END")
            {
                PolindromeCheck(n, q);
                n = Console.ReadLine();
            } 
        }

        static void output(Queue<bool> q)
        {
            while(q.Count != 0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }

        static void PolindromeCheck(string a, Queue<bool> q)
        {
            bool check = true;
            int n = a.Length - 1;
            for (int i = 0; i <= n / 2; i++)
            {
                if (a[i] != a[n - i])
                {
                    check = false;
                    break;
                }
            }
            if (check) q.Enqueue(true);
            else q.Enqueue(false);
        }
    }
}
