namespace BorderControl.Core
{
    using BorderControl.Models;
    using BorderControl.Models.Interfaces;
    using Interfaces;
    using System.Collections.Generic;
    using BorderControl.IO.Interfaces;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly List<IIdentifiable> identifiables;

        private Engine()
        {
            identifiables = new List<IIdentifiable>();
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
                if (cmd.Length == 3) identifiables.Add(new Person(cmd[2]));
                else if(cmd.Length == 2) identifiables.Add(new Robot(cmd[1]));
                input = reader.ReadLine();
            }
            string fakes = reader.ReadLine();
            foreach (var item in identifiables)
            {
                if (item.CheckId(fakes)) writer.WriteLine(item.Id);
            }
        }
    }
}
