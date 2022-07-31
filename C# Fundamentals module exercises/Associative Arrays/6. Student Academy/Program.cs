using System;
using System.Collections.Generic;

namespace _6._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();
            int numberOfCmds = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCmds; i++)
            {
                string studentName = Console.ReadLine();
                if (!students.ContainsKey(studentName)) students.Add(studentName, new List<double>());
                students[studentName].Add(double.Parse(Console.ReadLine()));
            }
            foreach (var student in students)
            {
                double sum = 0;
                foreach (var grade in student.Value)
                {
                    sum += grade;
                }
                if(sum / student.Value.Count >= 4.5) Console.WriteLine($"{student.Key} -> {sum / student.Value.Count:f2}");
            }
        }
    }
}
