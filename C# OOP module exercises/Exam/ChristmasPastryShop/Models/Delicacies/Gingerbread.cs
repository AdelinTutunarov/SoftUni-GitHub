﻿namespace ChristmasPastryShop.Models.Delicacies
{
    public class Gingerbread : Delicacy
    {
        private const double PRICE = 4;

        public Gingerbread(string name) : base(name, PRICE) {  }
    }
}
