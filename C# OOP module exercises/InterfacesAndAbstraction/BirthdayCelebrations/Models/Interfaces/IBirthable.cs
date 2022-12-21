namespace BirthdayCelebrations.Models.Interfaces
{
    public interface IBirthable
    {
        public string BirthDate { get; }
        bool CheckBirthDate(string date);
    }
}
