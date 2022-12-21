namespace ChristmasPastryShop.Core
{
    using ChristmasPastryShop.Models.Booths;
    using ChristmasPastryShop.Models.Booths.Contracts;
    using ChristmasPastryShop.Models.Cocktails;
    using ChristmasPastryShop.Models.Cocktails.Contracts;
    using ChristmasPastryShop.Models.Delicacies;
    using ChristmasPastryShop.Models.Delicacies.Contracts;
    using ChristmasPastryShop.Repositories;
    using ChristmasPastryShop.Utilities.Messages;
    using Contracts;
    using System.Linq;
    using System.Text;

    public class Controller : IController
    {
        private BoothRepository booths;

        public Controller()
        {
            booths = new BoothRepository();
        }

        public string AddBooth(int capacity)
        {
            int boothId = booths.Models.Count + 1;
            booths.AddModel(new Booth(boothId, capacity));
            return string.Format(OutputMessages.NewBoothAdded, boothId, capacity);
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);
            switch (cocktailTypeName)
            {
                case "Hibernation":
                    if (size != "Small" && size != "Middle" && size != "Large")
                        return string.Format(OutputMessages.InvalidCocktailSize, size);
                    if (booth.CocktailMenu.Models.FirstOrDefault(c => c.Name == cocktailName && c.Size == size) != null)
                        return string.Format(OutputMessages.CocktailAlreadyAdded, size, cocktailName);
                    booth.CocktailMenu.AddModel(new Hibernation(cocktailName,size));
                    return string.Format(OutputMessages.NewCocktailAdded, size, cocktailName, cocktailTypeName);
                    
                case "MulledWine":
                    if (size != "Small" && size != "Middle" && size != "Large")
                        return string.Format(OutputMessages.InvalidCocktailSize, size);
                    if (booth.CocktailMenu.Models.FirstOrDefault(c => c.Name == cocktailName && c.Size == size) != null)
                        return string.Format(OutputMessages.CocktailAlreadyAdded, size, cocktailName);
                    booth.CocktailMenu.AddModel(new MulledWine(cocktailName, size));
                    return string.Format(OutputMessages.NewCocktailAdded, size, cocktailName, cocktailTypeName);
                    
                default:
                    return string.Format(OutputMessages.InvalidCocktailType, cocktailTypeName);
            }
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);
            switch (delicacyTypeName)
            {
                case "Gingerbread":
                    if(booth.DelicacyMenu.Models.FirstOrDefault(d => d.Name == delicacyName) != null)
                    {
                        return string.Format(OutputMessages.DelicacyAlreadyAdded);
                    }
                    booth.DelicacyMenu.AddModel(new Gingerbread(delicacyName));
                    return string.Format(OutputMessages.NewDelicacyAdded, delicacyTypeName, delicacyName);
                case "Stolen":
                    if (booth.DelicacyMenu.Models.FirstOrDefault(d => d.Name == delicacyName) != null)
                    {
                        return string.Format(OutputMessages.DelicacyAlreadyAdded);
                    }
                    booth.DelicacyMenu.AddModel(new Stolen(delicacyName));
                    return string.Format(OutputMessages.NewDelicacyAdded, delicacyTypeName, delicacyName);
                default:
                    return string.Format(OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }
        }

        public string BoothReport(int boothId)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);
            return booth.ToString();
        }

        public string LeaveBooth(int boothId)
        {
            StringBuilder sb = new StringBuilder();
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            booth.Charge();
            booth.ChangeStatus();
            sb.AppendLine($"Bill {booth.CurrentBill:f2} lv");
            sb.AppendLine($"Booth {boothId} is now available!");

            return sb.ToString().Trim(); ;
        }

        public string ReserveBooth(int countOfPeople)
        {
            foreach (var booth in booths.Models)
            {
                if (booth.Capacity > countOfPeople)
                {
                    booth.ChangeStatus();
                    return string.Format(OutputMessages.BoothReservedSuccessfully, booth.BoothId, countOfPeople);
                }
            }
            return string.Format(OutputMessages.NoAvailableBooth, countOfPeople);
        }

        public string TryOrder(int boothId, string order)
        {
            ICocktail cocktail;
            IDelicacy delicacy;

            string[] orderArggs = order.Split("/");
            string itemTypeName = orderArggs[0];
            string itemName = orderArggs[1];
            int countOfTheOrderedPieces = int.Parse(orderArggs[2]);
            string size;

            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);
            switch (itemTypeName)
            {
                case "Hibernation":

                    size = orderArggs[3];
                    cocktail = booth.CocktailMenu.Models.FirstOrDefault(c => c.Name == itemName && c.Size == size);
                    if (cocktail == null) return string.Format(OutputMessages.CocktailStillNotAdded, itemTypeName, itemName);
                    booth.UpdateCurrentBill(countOfTheOrderedPieces);
                    return string.Format(OutputMessages.SuccessfullyOrdered, booth.BoothId, countOfTheOrderedPieces, itemName);
                    
                case "MulledWine":

                    size = orderArggs[3];
                    cocktail = booth.CocktailMenu.Models.FirstOrDefault(c => c.Name == itemName && c.Size == size);
                    if (cocktail == null) return string.Format(OutputMessages.CocktailStillNotAdded, itemTypeName, itemName);
                    booth.UpdateCurrentBill(countOfTheOrderedPieces);
                    return string.Format(OutputMessages.SuccessfullyOrdered, booth.BoothId, countOfTheOrderedPieces, itemName);

                case "Gingerbread":

                    delicacy = booth.DelicacyMenu.Models.FirstOrDefault(d => d.Name == itemName);
                    if (delicacy == null) return string.Format(OutputMessages.CocktailStillNotAdded, itemTypeName, itemName);
                    booth.UpdateCurrentBill(countOfTheOrderedPieces);
                    return string.Format(OutputMessages.SuccessfullyOrdered, booth.BoothId, countOfTheOrderedPieces, itemName);

                case "Stolen":

                    delicacy = booth.DelicacyMenu.Models.FirstOrDefault(d => d.Name == itemName);
                    if (delicacy == null) return string.Format(OutputMessages.CocktailStillNotAdded, itemTypeName, itemName);
                    booth.UpdateCurrentBill(countOfTheOrderedPieces);
                    return string.Format(OutputMessages.SuccessfullyOrdered, booth.BoothId, countOfTheOrderedPieces, itemName);

                default:
                    return string.Format(OutputMessages.NotRecognizedType, itemTypeName);
            }
        }
    }
}
