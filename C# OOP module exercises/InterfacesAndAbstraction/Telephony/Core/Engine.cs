namespace Telephony.Core
{
    using Interfaces;
    using System;
    using Telephony.Exeptions;
    using Telephony.IO.Interfaces;
    using Telephony.Models;
    using Telephony.Models.Interfaces;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ISmartPhone smartPhone;
        private readonly IStationaryPhone stationaryPhone;

        private Engine()
        {
            stationaryPhone = new StationaryPhone();
            smartPhone = new SmartPhone();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string[] numbers = reader.ReadLine().Split(" ");
            string[] urls = reader.ReadLine().Split(" ");
            foreach (var number in numbers)
            {
                try
                {
                    if (number.Length == 10) writer.WriteLine(smartPhone.Call(number));
                    else if (number.Length == 7) writer.WriteLine(stationaryPhone.Call(number));
                    else throw new InvalidPhoneNumberExeption();
                }
                catch (InvalidPhoneNumberExeption ipne)
                {
                    writer.WriteLine(ipne.Message);
                }
            }
            foreach (var url in urls)
            {
                try
                {
                    writer.WriteLine(smartPhone.Browse(url));
                }
                catch (InvalidURLExeption iue)
                {
                    writer.WriteLine(iue.Message);
                }
            }

        }
    }
}
