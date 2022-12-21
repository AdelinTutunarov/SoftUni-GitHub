namespace Telephony.Models
{
    using System.Linq;
    using Interfaces;
    using Telephony.Exeptions;
    public class SmartPhone : ISmartPhone
    {
        public string Browse(string url)
        {
            if (!ValidateURL(url)) throw new InvalidURLExeption();
            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (!ValidateNumber(number)) throw new InvalidPhoneNumberExeption();
            return $"Calling... {number}";
        }

        private bool ValidateNumber(string number) => number.All(ch => char.IsDigit(ch));
        private bool ValidateURL(string url) => !url.Any(ch => char.IsDigit(ch));
    }
}
