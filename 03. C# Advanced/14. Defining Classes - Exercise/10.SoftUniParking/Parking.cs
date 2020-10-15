using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;


        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        public int Capacity { get; set; }
        public int Count => cars.Count();

        public string AddCar(Car car)
        {
            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return $"Car with that registration number, already exists!";
            }

            else if (cars.Count >= capacity)
            {
                return $"Parking is full!";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }

        }
        public string RemoveCar(string registrationNumber)
        {
            if (!cars.Any(x => x.RegistrationNumber == registrationNumber))
            {
                return $"Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.Remove(cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber));
                return $"Successfully removed {registrationNumber}";
            }
        }
        public Car GetCar(string registrationNumber)
        {
            return cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var currentNumber in registrationNumbers)
            {
                cars.RemoveAll(x => x.RegistrationNumber == currentNumber);
            }
        }
    }
}