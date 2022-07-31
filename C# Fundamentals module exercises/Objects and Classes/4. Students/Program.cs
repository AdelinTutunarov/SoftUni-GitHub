using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var studentsList = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                var student = new Student(input[0], input[1], double.Parse(input[2]));
                studentsList.Add(student);
            }
            studentsList = studentsList.OrderByDescending(student => student.grade).ToList();
            foreach (var i in studentsList)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Student
    {
        public Student(string fname, string sname, double gr)
        {
            this.firstName = fname;
            this.lastName = sname;
            this.grade = gr;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public double grade { get; set; }
        public override string ToString() => $"{firstName} {lastName}: {grade:f2}";
    }
}
