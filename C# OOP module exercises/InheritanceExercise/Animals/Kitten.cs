using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    internal class Kitten : Cat
    {
        private const string kittenGender = "Female";
        public Kitten(string name, int age) : base(name, age, kittenGender)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
