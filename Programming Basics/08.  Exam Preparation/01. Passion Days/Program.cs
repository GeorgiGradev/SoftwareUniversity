namespace PassionDays
{
    using System;

    class PassionDays
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());

            int countPurchases = 0;
            string command = string.Empty;

            // skip any commands before "mall.Enter"
            do { command = Console.ReadLine(); } while (command != "mall.Enter");

            // process commands until "mall.Exit"
            while (true)
            {
                command = Console.ReadLine();
                if (command == "mall.Exit") break;

                foreach (char action in command)
                {
                    if (action == '*') { budget += 10; continue; }

                    double price = 0;
                    if (char.IsLetter(action) && char.IsUpper(action)) { price = 0.5m * (int)action; }
                    else if (char.IsLetter(action) && char.IsLower(action)) { price = 0.3m * (int)action; }
                    else if (action == '%') { price = budget / 2; }
                    else { price = (int)action; }

                    if (budget < price || budget == 0) continue;

                    budget -= price;
                    countPurchases++;
                }
            }

            // display results
            string purchases = countPurchases == 0 ? "No" : countPurchases.ToString();
            Console.WriteLine($"{purchases} purchases. Money left: {budget:f2} lv.");
        }
    }
}