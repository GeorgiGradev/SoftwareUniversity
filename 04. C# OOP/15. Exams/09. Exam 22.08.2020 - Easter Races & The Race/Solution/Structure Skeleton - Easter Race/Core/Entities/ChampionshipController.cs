namespace EasterRaces.Core.Entities
{
    using System;

    using EasterRaces.Core.Contracts;
    using EasterRaces.Utilities.Messages;
    using EasterRaces.Models.Drivers.Entities;
    using EasterRaces.Repositories.Entities;
    using EasterRaces.Models.Cars.Entities;
    using EasterRaces.Models.Cars.Contracts;
    using EasterRaces.Models.Drivers.Contracts;
    using EasterRaces.Models.Races.Entities;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ChampionshipController : IChampionshipController
    {
        private readonly DriverRepository driverRepository;
        private readonly CarRepository carRepository;
        private readonly RaceRepository raceRepository;     
        
        private const int MinRaceParticipants = 3;

        public ChampionshipController() 
        {
            driverRepository = new DriverRepository();
            carRepository = new CarRepository();
            raceRepository = new RaceRepository();
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            if (carRepository.GetByName(model) != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CarExists, model));
            }
            Car car = null;
            if (type == "Muscle")
            {
                car = new MuscleCar(model, horsePower);
            }
            else if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
            }
            carRepository.Add(car);
            return string.Format(OutputMessages.CarCreated, car.GetType().Name, model);
        }

        public string CreateDriver(string driverName) 
        {
            if (driverRepository.GetByName(driverName) != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriversExists, driverName));
            }
            Driver driver = new Driver(driverName);
            driverRepository.Add(driver);
            return string.Format(OutputMessages.DriverCreated, driverName);
        }
        public string CreateRace(string name, int laps) 
        {
            if (raceRepository.GetByName(name) != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, name));
            }
            Race race = new Race(name, laps);
            raceRepository.Add(race);
            return string.Format(OutputMessages.RaceCreated, name);
        }

        public string AddCarToDriver(string driverName, string carModel) 
        {
            if (driverRepository.GetByName(driverName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }
            if (carRepository.GetByName(carModel) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarNotFound, carModel));
            }
            IDriver driver = driverRepository.GetByName(driverName);
            ICar car = carRepository.GetByName(carModel);
            driver.AddCar(car);
            return string.Format(OutputMessages.CarAdded, driverName, carModel);
        }


        public string AddDriverToRace(string raceName, string driverName) 
        {
            if (raceRepository.GetByName(raceName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }
            if (driverRepository.GetByName(driverName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }
            var driver = driverRepository.GetByName(driverName);
            var race = raceRepository.GetByName(raceName);
            race.AddDriver(driver);
            return string.Format(OutputMessages.DriverAdded, driverName, raceName);
        }

        public string StartRace(string raceName) 
        {
            var race = raceRepository.GetByName(raceName);
            if (race == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }
            if (race.Drivers.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName, MinRaceParticipants));
            }

            //Dictionary<string, double> dict = new Dictionary<string, double>();
            //double points = 0;
            //foreach (var driver in race.Drivers)
            //{
            //    points = driver.Car.CalculateRacePoints(race.Laps);
            //    dict.Add(driver.Name, points);
            //}
            //int counter = 0;
            //StringBuilder sb = new StringBuilder();
            //foreach (var driver in dict.OrderByDescending(x => x.Value))
            //{
            //    counter++;
            //    string driverName = driver.Key;
            //    if (counter == 1)
            //    {
            //        sb.AppendLine(string.Format(OutputMessages.DriverFirstPosition, driverName, raceName));
            //    }
            //    else if (counter == 2)
            //    {
            //        sb.AppendLine(string.Format(OutputMessages.DriverSecondPosition, driverName, raceName));
            //    }
            //    else if (counter == 3)
            //    {
            //        sb.AppendLine(string.Format(OutputMessages.DriverThirdPosition, driverName, raceName));
            //    }
            //}
            //raceRepository.Remove(race);
            //return sb.ToString().TrimEnd();

            List<IDriver> drivers = race.Drivers
                .OrderByDescending(d => d.Car.CalculateRacePoints(race.Laps))
                .Take(3)
                .ToList();

            int counter = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var driver in drivers)
            {
                counter++;
                if (counter == 1)
                {
                    sb.AppendLine(string.Format(OutputMessages.DriverFirstPosition, driver.Name, raceName));
                }
                else if (counter == 2)
                {
                    sb.AppendLine(string.Format(OutputMessages.DriverSecondPosition, driver.Name, raceName));
                }
                else if (counter == 3)
                {
                    sb.AppendLine(string.Format(OutputMessages.DriverThirdPosition, driver.Name, raceName));
                }
            }
            raceRepository.Remove(race);
            return sb.ToString().TrimEnd();
        }
    } 
}
