using AquaShop.Core.Contracts;
using AquaShop.Models;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Repositories.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IDecoration> decorations;
        private readonly ICollection<IAquarium> aquariums;

        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium;
            if (aquariumType == nameof(FreshwaterAquarium))
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType == nameof(SaltwaterAquarium)) 
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }
            this.aquariums.Add(aquarium);
            return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration;
            if(decorationType == nameof(Ornament))
            {
                decoration = new Ornament();
            }
            else if (decorationType == nameof(Plant))
            {
                decoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }
            this.decorations.Add(decoration);
            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IDecoration decoration = this.decorations.FindByType(decorationType);
            IAquarium aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            if (decoration == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }
            else
            {
                aquarium.AddDecoration(decoration);
                decorations.Remove(decoration);
                return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
            }
        }


        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            if (fishType != nameof(FreshwaterFish) && fishType != nameof(SaltwaterFish))
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }
            else
            {
                IAquarium currentAquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);
                string currentAquariumType = currentAquarium.GetType().Name;

                IFish fish;
                if (fishType == nameof(FreshwaterFish) && currentAquariumType == nameof(FreshwaterAquarium))
                {
                    fish = new FreshwaterFish(fishName, fishSpecies, price);
                }
                else if (fishType == nameof(SaltwaterFish) && currentAquariumType == nameof(SaltwaterAquarium))
                {
                    fish = new SaltwaterFish(fishName, fishSpecies, price);
                }
                else
                {
                    return OutputMessages.UnsuitableWater;
                }
                currentAquarium.AddFish(fish);
                return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
            }
        }
        public string FeedFish(string aquariumName)
        {
            var currentAquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);
            currentAquarium.Feed();
            return $"Fish fed: {currentAquarium.Fish.Count}";
        }
        public string CalculateValue(string aquariumName)
        {
            var currentAquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);
            decimal totalSum = 0;
            foreach (var item in currentAquarium.Decorations)
            {
                totalSum += item.Price;
            }
            foreach (var item in currentAquarium.Fish)
            {
                totalSum += item.Price;
            }
            return string.Format(OutputMessages.AquariumValue, aquariumName, totalSum);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var aquarium in aquariums)
            {
               sb.AppendLine(aquarium.GetInfo());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
