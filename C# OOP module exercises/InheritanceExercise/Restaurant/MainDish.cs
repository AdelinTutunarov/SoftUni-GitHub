using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Restaurant
{
    public class MainDish : Food
    {
        public MainDish(string name, decimal price, double grams) : base(name, price, grams)
        {
        }
    }
}
