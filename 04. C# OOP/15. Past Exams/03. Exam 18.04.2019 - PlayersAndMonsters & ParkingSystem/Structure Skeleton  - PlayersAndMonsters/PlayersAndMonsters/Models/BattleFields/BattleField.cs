using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayersAndMonsters.Models.BattleFields
{
    class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
           if(attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }
            this.ModifyBeginnerPlayer(attackPlayer);
            this.ModifyBeginnerPlayer(enemyPlayer);

            attackPlayer = BoostPlayer(attackPlayer);
            enemyPlayer = BoostPlayer(enemyPlayer);

           while (true)
            {
                var attackPlayerAttackPoints = attackPlayer.CardRepository
                    .Cards
                    .Select(c => c.DamagePoints)
                    .Sum();
                enemyPlayer.TakeDamage(attackPlayerAttackPoints);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                var enemyPlayerAttackPoints = enemyPlayer.CardRepository
                    .Cards
                    .Select(c => c.DamagePoints)
                    .Sum();
                attackPlayer.TakeDamage(enemyPlayerAttackPoints);


                if (attackPlayer.IsDead)
                {
                    break;
                }
            }
        }

        private void ModifyBeginnerPlayer(IPlayer player)
        {
            if (player is Beginner)
            {
                player.Health += 40;
                foreach (var item in player.CardRepository.Cards)
                {
                    item.DamagePoints += 30;
                }
            }
        }

        private IPlayer BoostPlayer(IPlayer player)
        {
            player.Health += player.CardRepository
                .Cards
                .Select(c => c.HealthPoints)
                .Sum();

            return player;
        }
    }
}
