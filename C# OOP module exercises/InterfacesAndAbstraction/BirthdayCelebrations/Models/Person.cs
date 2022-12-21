namespace BirthdayCelebrations.Models
{
    using Interfaces;

    public class Person : IIdentifiable, IBirthable
    {
        public Person(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthdate;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string BirthDate { get; private set; }

        public bool CheckBirthDate(string date)
        {
            string p = BirthDate.Substring(6);
            return string.Equals(p, date);
        }

        public bool CheckId(string fakes)
        {
            string p = Id.Substring(Id.Length - fakes.Length);
            return string.Equals(p, fakes);
        }
    }
}
