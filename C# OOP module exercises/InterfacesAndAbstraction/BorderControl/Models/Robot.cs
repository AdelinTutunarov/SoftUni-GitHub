namespace BorderControl.Models
{
    using Interfaces;

    public class Robot : IIdentifiable
    {
        private string id;

        public Robot(string id)
        {
            Id = id;
        }

        public string Id
        {
            get { return id; }
            private set { id = value; }
        }

        public bool CheckId(string fakes)
        {
            string p = id.Substring(id.Length - fakes.Length);
            return string.Equals(p,fakes);
        }
    }
}
