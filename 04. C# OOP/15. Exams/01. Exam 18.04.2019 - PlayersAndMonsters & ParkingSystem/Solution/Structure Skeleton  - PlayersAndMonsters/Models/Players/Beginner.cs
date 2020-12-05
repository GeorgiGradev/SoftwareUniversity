namespace PlayersAndMonsters.Models.Players
{
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;

    public class Beginner : Player
    {
        private const int InitialHealthPoints = 50;

        public Beginner(ICardRepository cardRepository, string username) 
            : base(cardRepository, username, InitialHealthPoints)
        {
        }
    }
}
