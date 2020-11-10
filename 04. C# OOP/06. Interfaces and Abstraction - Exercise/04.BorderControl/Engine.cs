using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;

namespace _04.BorderControl
{
    public static class Engine
    {
        public static void Run()
        {
            string input;

            List<IId> list = new List<IId>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string ID = tokens[2];
                    Human human = new Human(name, age, ID);
                    list.Add(human);
                }
                else if (tokens.Length == 2)
                {
                    string model = tokens[0];
                    string ID = tokens[1];
                    Robot robot = new Robot(model, ID);
                    list.Add(robot);
                }
            }

            int fakeNumber = int.Parse(Console.ReadLine());


            foreach (var item in list)
            {
                int endID = int.Parse(item.ID.Substring(item.ID.Length - fakeNumber.ToString().Length));


               if (endID == fakeNumber)
                {
                    Console.WriteLine(item.ID);
                }
                    
            }



        }
    }
}
