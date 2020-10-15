using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterDayPerson = double.Parse(Console.ReadLine());
            double foodDayPerson = double.Parse(Console.ReadLine());
            bool noEnergy = false;
            double totalFood = players * days * foodDayPerson;
            double totalWater = players * days * waterDayPerson;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;
                if (groupEnergy < 0)
                {
                    noEnergy = true;
                    break;
                }

                if (i % 2 == 0)
                {
                    totalWater *= 0.7;
                    groupEnergy *= 1.05;
                }
                if (i % 3 == 0)
                {
                    totalFood -= totalFood / players;
                    groupEnergy *= 1.1;
                }
            }

            if (noEnergy)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }
            else if (!noEnergy)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }

        }
    }
}
