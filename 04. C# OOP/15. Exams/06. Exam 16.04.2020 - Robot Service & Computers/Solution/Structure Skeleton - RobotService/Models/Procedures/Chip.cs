namespace RobotService.Models.Procedures
{
    using System;

    using RobotService.Models.Robots.Contracts;
    using RobotService.Utilities.Messages;

    public class Chip : Procedure
    {
        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime);

            if (robot.IsChipped == true)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.AlreadyChipped, robot.Name));
            }
            robot.Happiness -= 5; // TODO да се сложи преди проверката, ако не сработи
            robot.IsChipped = true;
            this.Robots.Add(robot); 
        }
    }
}
 