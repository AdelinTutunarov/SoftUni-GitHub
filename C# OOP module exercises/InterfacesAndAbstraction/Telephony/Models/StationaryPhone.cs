namespace Telephony.Models
{
    using System.Linq;
    using Interfaces;
    using Telephony.Exeptions;

    public class StationaryPhone : IStationaryPhone
    {
        public string Call(string number)
        {
            if (!ValidateNumber(number)) throw new InvalidPhoneNumberExeption();
            return $"Dialing... {number}";
        }

        private bool ValidateNumber(string number) => number.All(ch => char.IsDigit(ch));
    }
}
