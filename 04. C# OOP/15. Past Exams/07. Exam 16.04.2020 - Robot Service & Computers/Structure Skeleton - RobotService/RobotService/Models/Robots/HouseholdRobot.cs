namespace RobotService.Models.Robots
{
    using RobotService.Models.Robots.Contracts;

    public class HouseholdRobot : Robot
    {
        public HouseholdRobot(string name, int energy, int happiness, int procedureTime) 
            : base(name, energy, happiness, procedureTime)
        {
        }
    }
}
