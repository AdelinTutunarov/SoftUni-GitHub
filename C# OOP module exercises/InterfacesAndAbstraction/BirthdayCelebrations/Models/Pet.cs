namespace BirthdayCelebrations.Models
{
    using Interfaces;
    public class Pet : IBirthable
    {
        public Pet(string name, string birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string Name { get; private set; }
        public string BirthDate { get; private set; }

        public bool CheckBirthDate(string date)
        {
            string p = BirthDate.Substring(6);
            return string.Equals(p, date);
        }
    }
}
