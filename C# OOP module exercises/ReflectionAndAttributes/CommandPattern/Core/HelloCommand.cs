﻿namespace CommandPattern.Core
{
    using Contracts;
    public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return $"Hello, {args[0]}";
        }
    }
}
