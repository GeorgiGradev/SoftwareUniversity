using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine()); // savings
            List<int> drumSet = Console.ReadLine() // 
                .Split()
                .Select(int.Parse)
                .ToList();
            string Command_HitPower = Console.ReadLine();
            double backUpSavings = 0;

            List<int> drumSetBackUp = new List<int>(); // създаваме back up на оригиналният Drum Set

            for (int i = 0; i < drumSet.Count; i++) // запазваме оригиналните стойности на барабаните
            {
                drumSetBackUp.Add(drumSet[i]);
            }


            while (Command_HitPower != "Hit it again, Gabsy!")
            {
                int leftDrumPower = 0;

                for (int i = 0; i < drumSet.Count; i++) // отнемаме Power от барабаните
                {
                    leftDrumPower = drumSet[i] - int.Parse(Command_HitPower); // Power на барабана след удар

                    if (leftDrumPower > 0)// ако НЕ се е счупил барабан
                    {
                        drumSet[i] -= int.Parse(Command_HitPower);
                    }

                    else if (leftDrumPower <= 0) // ако се е счупил барабан
                    {
                        backUpSavings = savings;
                        savings -= 3 * drumSetBackUp[i]; // вземаме пари от Savings, използвайки стойността на back up списъка
                        if (savings >= 0) // ако парите стигат за нов барабан
                        {
                            drumSet.Insert(i + 1, drumSetBackUp[i]); // !!! възстановяваме счупеният барабан със оригиналната му стойност!!!п
                            drumSet.RemoveAt(i); // премахваме счупеният барабан
                        }
                        else // ако парите НЕ стигат за нов барабан
                        {
                            drumSet.RemoveAt(i); // ако парите НЕ стигат, махаме барабана и нулираме парите
                            drumSetBackUp.RemoveAt(i); // махаме и оригиналната стойност на барабана в back up списъка
                            savings = backUpSavings; // Savings възстановяват предишната си стойност
                            i = i - 1; // връшаме индекса на оригиналното му място
                        }
                    }
                }

                Command_HitPower = Console.ReadLine();
            }
            if (drumSet.Count > 0)
            {
                Console.WriteLine(string.Join(" ", drumSet));
            }
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
