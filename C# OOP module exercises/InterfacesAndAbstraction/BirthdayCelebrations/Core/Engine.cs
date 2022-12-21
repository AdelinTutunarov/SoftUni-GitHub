namespace BirthdayCelebrations.Core
{
    using BirthdayCelebrations.Models;
    using BirthdayCelebrations.Models.Interfaces;
    using Interfaces;
    using System.Collections.Generic;
    using BirthdayCelebrations.IO.Interfaces;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly List<IBirthable> birthables;

        private Engine()
        {
            birthables = new List<IBirthable>();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string input = reader.ReadLine();
            while (input != "End")
            {
                string[] cmd = input.Split(' ');
                switch (cmd[0])
                {
                    case "Citizen":
                        birthables.Add(new Person(cmd[1], int.Parse(cmd[2]), cmd[3], cmd[4]));
                        break;
                    case "Pet":
                        birthables.Add(new Pet(cmd[1], cmd[2]));
                        break;
                    default:
                        break;
                }
                input = reader.ReadLine();
            }
            string date = reader.ReadLine();
            foreach (var item in birthables)
            {
                if (item.CheckBirthDate(date)) writer.WriteLine(item.BirthDate);
            }
        }
    }
}
