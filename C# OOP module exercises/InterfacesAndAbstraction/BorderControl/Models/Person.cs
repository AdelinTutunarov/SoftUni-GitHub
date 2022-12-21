namespace BorderControl.Models
{
    using Interfaces;

    public class Person : IIdentifiable
    {
        private string id;

        public Person( string id)
        {
            this.id = id;
        }
        public string Id
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }
        public bool CheckId(string fakes)
        {
            string p = id.Substring(id.Length - fakes.Length);
            return string.Equals(p,fakes);
        }
    }
}
