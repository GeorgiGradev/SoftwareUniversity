using System;

namespace _05._08._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            string maxMovie = "";
            string minMovie = "";
            double totalRating = 0;

            for (int i = 0; i < n; i++)
            {
                string movie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                if (rating > maxRating)
                {
                    maxRating = rating;
                    maxMovie = movie;
                }
                if (rating < minRating)
                {
                    minRating = rating;
                    minMovie = movie;
                }
                totalRating += rating;
            }

            Console.WriteLine($"{maxMovie} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{minMovie} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {totalRating/(1.0*n):f1}");



        }
    }
}
