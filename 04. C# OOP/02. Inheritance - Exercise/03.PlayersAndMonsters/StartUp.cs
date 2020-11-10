 using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Elf elf = new Elf("Name", 2);
            Console.WriteLine(elf);
        }
    }
} 