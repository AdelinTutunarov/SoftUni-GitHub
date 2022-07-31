using System;
using System.Collections.Generic;

namespace _5._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            string[] cmd = Console.ReadLine().Split(" : ");
            while (cmd[0] != "end")
            {
                if(!courses.ContainsKey(cmd[0])) courses.Add(cmd[0], new List<string>());
                courses[cmd[0]].Add(cmd[1]);
                cmd = Console.ReadLine().Split(" : ");
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
