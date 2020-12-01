using System;

namespace VetClinic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository
            Clinic clinic = new Clinic(20);

            // Initialize entity
            Pet dog = new Pet("Ellias", 5, "Tim");
            Pet cat = new Pet("Bella", 1, "Mia");
            Pet bunny = new Pet("Zak", 4, "Jon");
            Pet dog2 = new Pet("Ellias2", 7, "Tim2");
            Pet cat2 = new Pet("Bella2", 9, "Mia2");

            // Add Pet
            clinic.Add(dog);
            clinic.Add(cat);
            clinic.Add(bunny);
            clinic.Add(dog2);
            clinic.Add(cat2);


            // Print Pet
            Console.WriteLine(dog); // Ellias 5 (Tim)


            // Remove Pet
            Console.WriteLine(clinic.Remove("Ellias")); // True
            Console.WriteLine(clinic.Remove("Pufa")); // False


            // Get Oldest Pet
            Pet oldestPet = clinic.GetOldestPet();
            Console.WriteLine(oldestPet); // Bella2 9 (Mia2)

            // Get Pet
            Pet pet = clinic.GetPet("Bella", "Mia");
            Console.WriteLine(pet); // Bella 1 (Mia)

            // Count
            Console.WriteLine(clinic.Count); // 4

            // Get Statistics
            Console.WriteLine(clinic.GetStatistics());
            //The clinic has the following patients:
            //Bella Mia
            //Zak Jon
            //Ellias2 Tim2
            //Bella2 Mia2

        }
    }
}
