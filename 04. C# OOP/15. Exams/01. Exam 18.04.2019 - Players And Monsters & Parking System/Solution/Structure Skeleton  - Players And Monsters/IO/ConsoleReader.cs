using PlayersAndMonsters.IO.Contracts;
using System;


namespace PlayersAndMonsters.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
