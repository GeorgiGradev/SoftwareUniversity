namespace RobotService.Core
{
    using RobotService.Core.Contracts;
    using RobotService.Models.Garages;
    using RobotService.Models.Garages.Contracts;
    using RobotService.Models.Procedures;
    using RobotService.Models.Procedures.Contracts;
    using RobotService.Models.Robots;
    using RobotService.Models.Robots.Contracts;
    using RobotService.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Controller : IController
    {
        Garage garage = new Garage(); 
        // ако не работи
        // ===> private readonly IGarage garage;
        // да се инстанцира в празен конструктор  this.garage = new Garage();

        private readonly IList<IProcedure> procedures;

        public Controller()
        {
            this.procedures = new List<IProcedure>();
        }

        IProcedure procedure;

        public string Manufacture(string robotType, string name, int energy, int happiness, int procedureTime)
        {
            IRobot robotToCreate;

            if (robotType == nameof(HouseholdRobot))
            {
                robotToCreate = new HouseholdRobot(name, energy, happiness, procedureTime);
            }
            else if (robotType == nameof(PetRobot))
            {
                robotToCreate = new PetRobot(name, energy, happiness, procedureTime);
            }
            else if (robotType == nameof(WalkerRobot))
            {
                robotToCreate = new WalkerRobot(name, energy, happiness, procedureTime);
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidRobotType, robotType));
            }
            garage.Manufacture(robotToCreate);
            return string.Format(OutputMessages.RobotManufactured, name);
        }

        public string Chip(string robotName, int procedureTime)
        {
            ValidateIfRobotExists(robotName);
            IRobot robotForProcedure = garage.Robots[robotName];

            procedure = procedures.FirstOrDefault(x => x.GetType().Name == nameof(Chip));
            if (procedure == null)
            {
                procedure = new Chip();
            }

            procedure.DoService(robotForProcedure, procedureTime);
            procedures.Add(procedure);
            return string.Format(OutputMessages.ChipProcedure, robotName);
        }

        public string TechCheck(string robotName, int procedureTime)
        {
            ValidateIfRobotExists(robotName);
            IRobot robotForProcedure = garage.Robots[robotName];
            procedure = procedures.FirstOrDefault(x => x.GetType().Name == nameof(TechCheck));
            if (procedure == null)
            {
                procedure = new TechCheck();
            }
            procedure.DoService(robotForProcedure, procedureTime);
            procedures.Add(procedure);
            return string.Format(OutputMessages.TechCheckProcedure, robotName);
        }

        public string Rest(string robotName, int procedureTime)
        {
            ValidateIfRobotExists(robotName);
            IRobot robotForProcedure = garage.Robots[robotName];
            procedure = procedures.FirstOrDefault(x => x.GetType().Name == nameof(Rest));
            if (procedure == null)
            {
                procedure = new Rest();
            }
            procedure.DoService(robotForProcedure, procedureTime);
            procedures.Add(procedure);
            return string.Format(OutputMessages.RestProcedure, robotName);
        }

        public string Work(string robotName, int procedureTime)
        {
            ValidateIfRobotExists(robotName);
            IRobot robotForProcedure = garage.Robots[robotName];
            procedure = procedures.FirstOrDefault(x => x.GetType().Name == nameof(Work));
            if (procedure == null)
            {
                procedure = new Work();
            }
            procedure.DoService(robotForProcedure, procedureTime);
            procedures.Add(procedure);
            return string.Format(OutputMessages.WorkProcedure, robotName, procedureTime);
        }

        public string Charge(string robotName, int procedureTime)
        {
            ValidateIfRobotExists(robotName);
            IRobot robotForProcedure = garage.Robots[robotName];
            procedure = procedures.FirstOrDefault(x => x.GetType().Name == nameof(Charge));
            if (procedure == null)
            {
                procedure = new Charge();
            }
            procedure.DoService(robotForProcedure, procedureTime);
            procedures.Add(procedure);
            return string.Format(OutputMessages.ChargeProcedure, robotName);
        }

        public string Polish(string robotName, int procedureTime)
        {
            ValidateIfRobotExists(robotName);
            IRobot robotForProcedure = garage.Robots[robotName];
            procedure = procedures.FirstOrDefault(x => x.GetType().Name == nameof(Polish));
            if (procedure == null)
            {
                procedure = new Polish();
            }
            procedure.DoService(robotForProcedure, procedureTime);
            procedures.Add(procedure);
            return string.Format(OutputMessages.PolishProcedure, robotName);
        }

        public string Sell(string robotName, string ownerName)
        {
            ValidateIfRobotExists(robotName);
            IRobot robotToSell = garage.Robots[robotName];
            garage.Sell(robotName, ownerName);
            if (robotToSell.IsChipped == true)
            {
                return string.Format(OutputMessages.SellChippedRobot, ownerName);
            }
            else
            {
                return string.Format(OutputMessages.SellNotChippedRobot, ownerName);
            }
        }

        public string History(string procedureType)
        {
            var procedure = procedures
                .FirstOrDefault(p => p.GetType().Name == procedureType);

            return procedure.History();
        }



        private void ValidateIfRobotExists(string robotName)
        {
            if (!garage.Robots.ContainsKey(robotName))
            {
                throw new AggregateException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }
        }
    }
}
