namespace RobotService.Models.Garages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RobotService.Models.Garages.Contracts;
    using RobotService.Models.Robots.Contracts;
    using RobotService.Utilities.Messages;

    public class Garage : IGarage
    {
        private const int Capacity = 10;
        private readonly Dictionary<string, IRobot> robots;

        public Garage()
        {
            this.robots = new Dictionary<string, IRobot>();
        }

        public IReadOnlyDictionary<string, IRobot> Robots => this.robots;

        public void Manufacture(IRobot robot)
        {
           if (robots.Count == Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }
           else if (robots.ContainsKey(robot.Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingRobot, robot.Name));
            }
            robots.Add(robot.Name, robot);
        }

        public void Sell(string robotName, string ownerName)
        {
           if (!robots.ContainsKey(robotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            IRobot robotToSell = robots[robotName];
            robotToSell.Owner = ownerName;
            robotToSell.IsBought = true;
            robots.Remove(robotName);
        }
    }
}
