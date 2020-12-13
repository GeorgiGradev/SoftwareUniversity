namespace PlayersAndMonsters.Repositories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;

    public class CardRepository : ICardRepository
    {
        private readonly Dictionary<string, ICard> cardsByName;

        public CardRepository()
        {
            cardsByName = new Dictionary<string, ICard>();
        }

        public int Count => this.cardsByName.Count;
        public IReadOnlyCollection<ICard> Cards => this.cardsByName.Values.ToList().AsReadOnly();

        public void Add(ICard card)
        {
            if (card is null)
            {
                throw new ArgumentException("Card cannot be null!");
            }
            if (cardsByName.ContainsKey(card.Name))
            {
                throw new ArgumentException($"Card {card.Name} already exists!");
            }
            this.cardsByName.Add(card.Name, card);
        }
        public bool Remove(ICard card)
        {
            if (card is null)
            {
                throw new ArgumentException("Card cannot be null!");
            }
           return cardsByName.Remove(card.Name);
        }
        public ICard Find(string name)
        {
            ICard card = null;
            if (cardsByName.ContainsKey(name))
            {
                card = this.cardsByName[name];
            }
            return card;
        }

    }
}
