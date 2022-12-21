namespace ChristmasPastryShop.Repositories
{
    using Contracts;
    using Models.Booths.Contracts;
    using System.Collections.Generic;

    public class BoothRepository : IRepository<IBooth>
    {
        private List<IBooth> models;

        public BoothRepository()
        {
            models = new List<IBooth>();
        }

        public IReadOnlyCollection<IBooth> Models => models.AsReadOnly();

        public void AddModel(IBooth model)
        {
            models.Add(model);
        }
    }
}
