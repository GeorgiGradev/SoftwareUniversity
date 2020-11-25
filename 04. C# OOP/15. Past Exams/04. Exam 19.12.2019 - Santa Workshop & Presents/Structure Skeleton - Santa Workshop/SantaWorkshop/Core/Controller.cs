
namespace SantaWorkshop.Core
{
    using SantaWorkshop.Core.Contracts;
    using SantaWorkshop.Models.Dwarfs;
    using SantaWorkshop.Models.Dwarfs.Contracts;
    using SantaWorkshop.Models.Instruments;
    using SantaWorkshop.Models.Instruments.Contracts;
    using SantaWorkshop.Models.Presents;
    using SantaWorkshop.Models.Presents.Contracts;
    using SantaWorkshop.Models.Workshops;
    using SantaWorkshop.Repositories;
    using SantaWorkshop.Utilities.Messages;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Controller : IController
    {
        private DwarfRepository dwarfs;
        private PresentRepository presents;

        public Controller()
        {
            this.dwarfs = new DwarfRepository();
            this.presents = new PresentRepository();
        }

        public string AddDwarf(string dwarfType, string dwarfName)
        {
            IDwarf dwarf;
            if (dwarfType == nameof(HappyDwarf))
            {
                dwarf = new HappyDwarf(dwarfName);
            }
            else if (dwarfType == nameof(SleepyDwarf))
            {
                dwarf = new SleepyDwarf(dwarfName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDwarfType);
            }
            this.dwarfs.Add(dwarf);
            return string.Format(OutputMessages.DwarfAdded, dwarfType, dwarfName);
        }

        public string AddInstrumentToDwarf(string dwarfName, int power)
        {
            IDwarf currentDwarf = this.dwarfs.FindByName(dwarfName);
            if (currentDwarf == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentDwarf);
            }
            IInstrument currentInstrument = new Instrument(power);
            currentDwarf.AddInstrument(currentInstrument);
            return string.Format(OutputMessages.InstrumentAdded, power, dwarfName);
        }

        public string AddPresent(string presentName, int energyRequired)
        {
            IPresent present = new Present(presentName, energyRequired);
            presents.Add(present);
            return string.Format(OutputMessages.PresentAdded, presentName);
        }

        public string CraftPresent(string presentName)
        {
            Workshop workshop = new Workshop();
            IPresent currentPresent = this.presents.FindByName(presentName);
                     ICollection<IDwarf> dwarves = this.dwarfs
                .Models
                .Where(x => x.Energy >= 50)
                .OrderByDescending(x => x.Energy)
                .ToList();

            if (!dwarves.Any())
            {
                throw new InvalidOperationException(ExceptionMessages.DwarfsNotReady);
            }

             while(dwarves.Any())
            {
                IDwarf currentDwarf = dwarves.First();
                workshop.Craft(currentPresent, currentDwarf);

                if (currentDwarf.Energy == 0)
                {
                    dwarves.Remove(currentDwarf);
                    this.dwarfs.Remove(currentDwarf);
                }
                 
                if (currentPresent.IsDone())
                {
                    break;
                }

                if (!currentDwarf.Instruments.Any())
                {
                    dwarves.Remove(currentDwarf);
                }
            }
             if (currentPresent.IsDone())
            {
                return string.Format(OutputMessages.PresentIsDone, presentName);
            }
             else
            {
                return string.Format(OutputMessages.PresentIsNotDone, presentName);
            }
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{presents.Models.Count(p=>p.IsDone())} presents are done!");
            sb.AppendLine("Dwarfs info: ");
            foreach (var dwarf in dwarfs.Models)
            {
                sb.AppendLine($"Name: {dwarf.Name}");
                sb.AppendLine($"Energy: {dwarf.Energy}");
                sb.AppendLine($"Instruments: {dwarf.Instruments.Count(x => !x.IsBroken())} not broken left"); 
            }
            return sb.ToString().TrimEnd();
        }
    }
}
