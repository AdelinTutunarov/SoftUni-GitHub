using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }
        List<Renovator> renovators;
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public int Count { get { return renovators.Count; } }

        public string AddRenovator(Renovator renovator)
        {
            if (renovator.Name == null || renovator.Name == String.Empty || renovator.Type == null || renovator.Type == String.Empty)
                return "Invalid renovator's information.";
            if (renovators.Count >= NeededRenovators)
                return "Renovators are no more needed.";
            if (renovator.Rate > 350)
                return "Invalid renovator's rate.";
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            var targetRenovator = this.renovators.FirstOrDefault(x => x.Name == name);
            if (targetRenovator == null) return false;
            this.renovators.Remove(targetRenovator);
            return true;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = 0;
            while (this.renovators.FirstOrDefault(x => x.Type == type) != null)
            {
                var targetRenovator = this.renovators.FirstOrDefault(x => x.Type == type);
                this.renovators.Remove(targetRenovator);
                count++;
            }
            return count;
        }
        public Renovator HireRenovator(string name)
        {
            for (int i = 0; i < renovators.Count; i++)
            {
                if (renovators[i].Name == name) { renovators[i].Hired = true; return renovators[i]; }
            }
            return null;
        }
        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> ret = new List<Renovator>();
            for (int i = 0; i < renovators.Count; i++)
            {
                if (renovators[i].Days >= days) ret.Add(renovators[i]);
            }
            return ret;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Renovators available for Project {project}:");
            foreach (Renovator renovator in renovators)
            {
                sb.AppendLine(renovator.ToString());
            }
            return sb.ToString();
        }
    }
}
