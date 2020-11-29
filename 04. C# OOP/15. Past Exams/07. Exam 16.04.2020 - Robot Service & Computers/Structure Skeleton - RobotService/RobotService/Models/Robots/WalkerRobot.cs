namespace RobotService.Models.Robots
{
    using RobotService.Models.Robots.Contracts;

    public class WalkerRobot : Robot
    {
        public WalkerRobot(string name, int energy, int happiness, int procedureTime) 
            : base(name, energy, happiness, procedureTime)
        {
        }
    }
}
