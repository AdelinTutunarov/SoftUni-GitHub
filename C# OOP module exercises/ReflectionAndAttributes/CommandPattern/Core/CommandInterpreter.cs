namespace CommandPattern.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] cmdArgs = args.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
            string cmdName = cmdArgs[0];
            string[] invokeArgs = cmdArgs.Skip(1).ToArray();

            Assembly assembly = Assembly.GetEntryAssembly();
            Type cmdType = assembly.GetTypes().FirstOrDefault(t => t.Name == $"{cmdName}Command");
            if (cmdType == null) throw new InvalidOperationException("Invalid command");

            MethodInfo executeMethodInfo = cmdType.GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .FirstOrDefault(m => m.Name == "Execute");
            if (executeMethodInfo == null) throw new InvalidOperationException("This command does not implement ICommand!");

            object cmdInstance = Activator.CreateInstance(cmdType);
            return (string)executeMethodInfo.Invoke(cmdInstance, new object[] { invokeArgs });
        }
    }
}
