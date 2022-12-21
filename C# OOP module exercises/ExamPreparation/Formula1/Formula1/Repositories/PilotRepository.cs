namespace Formula1.Repositories
{
    using Contracts;
    using Formula1.Models.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class PilotRepository : IRepository<IPilot>
    {
        private List<IPilot> models;

        public PilotRepository()
        {
            models = new List<IPilot>();
        }

        public IReadOnlyCollection<IPilot> Models => models.AsReadOnly();

        public void Add(IPilot model)
        {
            models.Add(model);
        }

        public IPilot FindByName(string name)
        {
            return models.FirstOrDefault(p => p.FullName == name);
        }

        public bool Remove(IPilot model)
        {
            return models.Remove(model);
        }
    }
}
