namespace RobotService.Models.Robots
{
    using RobotService.Models.Robots.Contracts;

    class PetRobot : Robot
    {
        public PetRobot(string name, int energy, int happiness, int procedureTime) 
            : base(name, energy, happiness, procedureTime)
        {
        }
    }
}
