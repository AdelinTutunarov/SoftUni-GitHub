namespace Formula1.Core
{
    using Contracts;
    using Formula1.Models;
    using Formula1.Repositories;
    using Formula1.Utilities;
    using System;

    public class Controller : IController
    {
        private PilotRepository pilotRepository;
        private RaceRepository raceRepository;
        private FormulaOneCarRepository carRepository;

        public Controller()
        {
            pilotRepository = new PilotRepository();
            raceRepository = new RaceRepository();
            carRepository = new FormulaOneCarRepository();
        }

        public string AddCarToPilot(string pilotName, string carModel)
        {
            throw new System.NotImplementedException();
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            throw new System.NotImplementedException();
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            if (carRepository.FindByName(model) != null)
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarExistErrorMessage, model));

            if (type == "Ferrari")
            {
                carRepository.Add(new Ferrari(model, horsepower, engineDisplacement));
                return string.Format(OutputMessages.SuccessfullyCreateCar, type, model);
            }
            else if (type == "Williams")
            {
                carRepository.Add(new Williams(model, horsepower, engineDisplacement));
                return string.Format(OutputMessages.SuccessfullyCreateCar, type, model);
            }
            else throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidTypeCar, type));
        }

        public string CreatePilot(string fullName)
        {
            if (pilotRepository.FindByName(fullName) != null)
                throw new InvalidOperationException(string.Format(ExceptionMessages.PilotExistErrorMessage, fullName));

            pilotRepository.Add(new Pilot(fullName));
            return string.Format(OutputMessages.SuccessfullyCreatePilot, fullName);
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            throw new System.NotImplementedException();
        }

        public string PilotReport()
        {
            throw new System.NotImplementedException();
        }

        public string RaceReport()
        {
            throw new System.NotImplementedException();
        }

        public string StartRace(string raceName)
        {
            throw new System.NotImplementedException();
        }
    }
}
