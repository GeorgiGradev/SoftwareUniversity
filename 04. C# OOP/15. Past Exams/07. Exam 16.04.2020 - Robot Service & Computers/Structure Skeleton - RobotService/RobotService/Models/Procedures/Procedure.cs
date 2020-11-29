namespace RobotService.Models.Procedures
{
    using System;

    using System.Collections.Generic;
    using System.Text;
    using RobotService.Models.Procedures.Contracts;
    using RobotService.Models.Robots.Contracts;
    using RobotService.Utilities.Messages;

    public abstract class Procedure : IProcedure
    {
        private ICollection<IRobot> robots;

        protected Procedure()
        {
            robots = new List<IRobot>();
        }

        protected ICollection<IRobot> Robots 
        {
            get => this.robots;
            set
            {
                this.robots = value;
            }
        }
 
        public string History()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            foreach (var robot in robots)
            {
                sb.AppendLine(robot.ToString());
            }
            return sb.ToString().TrimEnd();
        }
        public virtual void DoService(IRobot robot, int procedureTime)
        {
            if (robot.ProcedureTime < procedureTime)
            {
                throw new ArgumentException(ExceptionMessages.InsufficientProcedureTime);
            }
            robot.ProcedureTime -= procedureTime;
        }
    }
}
