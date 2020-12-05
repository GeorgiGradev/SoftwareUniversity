namespace PlayersAndMonsters.Models.BattleFields
{
    using System;
    using System.Linq;
    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;

    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }
            if (attackPlayer is Beginner)
            {
                attackPlayer.Health += 40;
                foreach (var card in attackPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
                //TODO 01.Test this one if it is working properly
                //attackPlayer.CardRepository.Cards.Select(x => x.DamagePoints += 30);
            }
            if (enemyPlayer is Beginner)
            {
                enemyPlayer.Health += 40;
                foreach (var card in enemyPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
                //enemyPlayer.CardRepository.Cards.Select(x => x.DamagePoints += 30);
            }

            enemyPlayer.Health += enemyPlayer.CardRepository
                     .Cards
                     .Select(c => c.HealthPoints)
                     .Sum();

            attackPlayer.Health += attackPlayer.CardRepository
                     .Cards
                     .Select(c => c.HealthPoints)
                     .Sum();

            //TODO 02.Test this one if it is working properly
            //foreach (var card in attackPlayer.CardRepository.Cards)
            //{
            //    attackPlayer.Health += card.HealthPoints;
            //}
            //foreach (var card in enemyPlayer.CardRepository.Cards)

            //{
            //    enemyPlayer.Health += card.HealthPoints;
            //}

            while (true)
            {
                var attackPlayerDamagePoints = attackPlayer.CardRepository.Cards.Select(x => x.DamagePoints).Sum();
                enemyPlayer.TakeDamage(attackPlayerDamagePoints);
                if (enemyPlayer.IsDead)
                {
                    break;
                }

                var enemyPlayerDamagePoints = enemyPlayer.CardRepository.Cards.Select(x => x.DamagePoints).Sum();
                attackPlayer.TakeDamage(enemyPlayerDamagePoints);
                if (attackPlayer.IsDead)
                {
                    break;
                }
            }
        }
    }
}
