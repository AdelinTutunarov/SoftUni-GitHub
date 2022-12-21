namespace CommandPattern.Core
{
    using Contracts;

    using IO;
    using IO.Contracts;
    using System;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandInterpreter interpreter;

        private Engine()
        {
            //these should come as arguments in the public constructor!!!
            reader = new ConsoleReader();
            writer = new ConsoleWriter();
        }

        public Engine(ICommandInterpreter interpreter) : this()
        {
            this.interpreter = interpreter;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string result = interpreter.Read(reader.ReadLine());
                    writer.WriteLine(result);
                }
                catch (InvalidOperationException ioe)
                {
                    writer.Write(ioe.Message);
                }
            }
        }
    }
}
