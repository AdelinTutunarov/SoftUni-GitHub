namespace BorderControl.Models.Interfaces
{
    public interface IIdentifiable
    {
        string Id { get; }
        bool CheckId(string fakes);
    }
}
