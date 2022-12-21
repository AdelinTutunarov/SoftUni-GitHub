namespace BirthdayCelebrations.Models
{
    using Interfaces;

    public class Robot : IIdentifiable
    {
        public Robot(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }

        public bool CheckId(string fakes)
        {
            string p = Id.Substring(Id.Length - fakes.Length);
            return string.Equals(p, fakes);
        }
    }
}
