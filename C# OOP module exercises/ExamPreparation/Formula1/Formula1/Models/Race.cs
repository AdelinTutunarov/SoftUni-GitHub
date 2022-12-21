namespace Formula1.Models
{
    using Contracts;
    using Formula1.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Race : IRace
    {
        private string raceName;
        private int numberOfLaps;
        private bool tookPlace;
        private ICollection<IPilot> pilots;

        private Race()
        {
            Pilots = new List<IPilot>();
            TookPlace = false;
        }

        public Race(string raceName, int numberOfLaps) : this()
        {
            RaceName = raceName;
            NumberOfLaps = numberOfLaps;
        }

        public string RaceName
        {
            get { return raceName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidRaceName, value));

                raceName = value;
            }
        }

        public int NumberOfLaps
        {
            get { return numberOfLaps; }
            private set
            {
                if (value < 1)
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidLapNumbers, value));

                numberOfLaps = value;
            }
        }

        public bool TookPlace
        {
            get { return tookPlace; }
            set { tookPlace = value; }
        }

        public ICollection<IPilot> Pilots
        {
            get { return pilots; }
            private set { pilots = value; }
        }


        public void AddPilot(IPilot pilot)
        {
            Pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            string p = TookPlace == true ? "Yes" : "No";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The { RaceName } race has:");
            sb.AppendLine($"Participants: { Pilots.Count }");
            sb.AppendLine($"Number of laps: { NumberOfLaps }");
            sb.AppendLine($"Took place: { p }");
            return sb.ToString().Trim();
        }
    }
}
