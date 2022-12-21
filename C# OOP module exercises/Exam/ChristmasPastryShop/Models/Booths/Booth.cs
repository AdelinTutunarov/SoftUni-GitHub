namespace ChristmasPastryShop.Models.Booths
{
    using System;
    using System.Text;
    using Contracts;
    using Cocktails.Contracts;
    using Delicacies.Contracts;
    using Repositories.Contracts;
    using Utilities.Messages;
    using ChristmasPastryShop.Repositories;

    public class Booth : IBooth
    {
        private int id;
        private int capacity;
        private IRepository<IDelicacy> delicacyMenu;
        private IRepository<ICocktail> cocktailMenu;
        private double currentBill;
        private double turnover;
        private bool isReserved;

        private Booth()
        {
            delicacyMenu = new DelicacyRepository();
            cocktailMenu = new CocktailRepository();
            CurrentBill = 0;
            Turnover = 0;
        }

        public Booth(int id, int capacity) : this()
        {
            BoothId = id;
            Capacity = capacity;
        }

        public int BoothId
        {
            get { return id; }
            private set { id = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException(ExceptionMessages.CapacityLessThanOne);

                capacity = value;
            }
        }

        public IRepository<IDelicacy> DelicacyMenu
        {
            get { return delicacyMenu; }
            private set { delicacyMenu = value; }
        }

        public IRepository<ICocktail> CocktailMenu
        {
            get { return cocktailMenu; }
            private set { cocktailMenu = value; }
        }

        public double CurrentBill
        {
            get { return currentBill; }
            set { currentBill = value; }
        }

        public double Turnover
        {
            get { return turnover; }
            set { turnover = value; }
        }

        public bool IsReserved
        {
            get { return isReserved; }
            set { isReserved = value; }
        }



        public void ChangeStatus()
        {
            if (IsReserved) IsReserved = false;
            else IsReserved = true;
        }

        public void Charge()
        {
            Turnover += CurrentBill;
            CurrentBill = 0;
        }

        public void UpdateCurrentBill(double amount)
        {
            CurrentBill += amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Booth: {BoothId}");
            sb.AppendLine($"Capacity: {Capacity}");
            sb.AppendLine($"Turnover: {Turnover:f2} lv");
            foreach (var cocktail in CocktailMenu.Models)
            {
                sb.AppendLine(cocktail.ToString());
            }
            foreach (var delicacy in DelicacyMenu.Models)
            {
                sb.AppendLine(delicacy.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
