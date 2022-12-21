namespace ChristmasPastryShop.Models.Cocktails
{
    public class MulledWine : Cocktail
    {
        private const double PRICE = 13.5;

        public MulledWine(string name, string size) : base(name, size, PRICE)
        {
        }
    }
}
