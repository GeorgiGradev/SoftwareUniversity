namespace PlayersAndMonsters
{
    using Core;
    using Core.Contracts;
    using Repositories;
    using Repositories.Contracts;
    using IO;
    using IO.Contracts;
    using System.IO;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //string pathFile = Path.Combine("../../../output.text");
            //File.Create(pathFile).Close();
            IReader reader = new ConsoleReader();
            //IWriter writer = new FileWriter(pathFile);
            IWriter writer = new ConsoleWriter();
            IPlayerRepository playerRepository = new PlayerRepository();
            ICardRepository cardRepository = new CardRepository();
            IManagerController managerController = new ManagerController(playerRepository, cardRepository);

            IEngine engine = new Engine(reader, writer, managerController);
            engine.Run();
        }
    }
}