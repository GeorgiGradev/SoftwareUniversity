
namespace CustomRandomList
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            string[] colection = new[] { "pesho", "gosho", "stoian" };
            RandomList rl = new RandomList(colection);

            Console.WriteLine(rl.RandomString());
        }
    }
}