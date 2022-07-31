using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (startIndex < 0) startIndex = 0;
                    if (endIndex > myList.Count - 1) endIndex = myList.Count - 1;
                    for (int i = endIndex; i > startIndex; i--)
                    {
                        myList[i - 1] += myList[i];
                        myList.RemoveAt(i);
                    }
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    List<string> devidedWord = new List<string>();
                    if (index < 0) index = 0;
                    else if (index > myList.Count - 1) index = myList.Count - 1;
                    int partitions = int.Parse(command[2]);
                    string word = myList[index];
                    myList.RemoveAt(index);
                    int parts = word.Length / partitions;
                    for (int i = 0; i < partitions; i++)
                    {
                        if(i == partitions - 1)
                        {
                            devidedWord.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            devidedWord.Add(word.Substring(i * parts, parts));
                        }
                    }
                    myList.InsertRange(index, devidedWord);
                }


                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", myList));
        }
    }
}
