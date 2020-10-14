using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            double periodInDays = double.Parse(Console.ReadLine());
            int doctors = 7;
            int patientsYes = 0;
            int patientsNo = 0;

            for (int i = 1; i <= periodInDays; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (i % 3 != 0)
                {
                    if (doctors >= patients)
                    {
                        patientsYes = patients + patientsYes;
                    }
                    else if (doctors < patients)
                    {
                        patientsYes = patientsYes + doctors;
                        patientsNo = patientsNo + (patients - doctors);
                    }
                }
                else
                {
                    if (patientsNo > patientsYes)
                    {
                        doctors += 1;
                        {
                            if (doctors >= patients)
                            {
                                patientsYes = patients + patientsYes;
                            }
                            else if (doctors < patients)
                            {
                                patientsYes = patientsYes + doctors;
                                patientsNo = patientsNo + (patients - doctors);
                            }
                        }
                    }
                    else
                    {
                        if (doctors >= patients)
                        {
                            patientsYes = patients + patientsYes;
                        }
                        else if (doctors < patients)
                        {
                            patientsYes = patientsYes + doctors;
                            patientsNo = patientsNo + (patients - doctors);
                        }
                    }
                }

            }
            Console.WriteLine($"Treated patients: {patientsYes}.");
            Console.WriteLine($"Untreated patients: {patientsNo}.");
        }
    }
}
