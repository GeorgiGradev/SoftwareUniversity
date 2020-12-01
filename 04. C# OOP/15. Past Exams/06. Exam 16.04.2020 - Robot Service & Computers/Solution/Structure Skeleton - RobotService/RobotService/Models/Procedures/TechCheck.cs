namespace RobotService.Models.Procedures
{
    using RobotService.Models.Robots.Contracts;

    public class TechCheck : Procedure
    {
        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime); //TODO Да се провери логиката  за energy , ако не работи
            robot.Energy -= 8;
            if (robot.IsChecked == true)
            {
                robot.Energy -= 8;
            }
            else
            {
                robot.IsChecked = true;
            } 
            this.Robots.Add(robot);
           
        }
    }
}
