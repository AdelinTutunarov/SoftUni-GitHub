namespace ChristmasPastryShop.Models.Delicacies
{
    public class Stolen : Delicacy
    {
        private const double PRICE = 3.5;

        public Stolen(string name) : base(name, PRICE) {  }
    }
}
