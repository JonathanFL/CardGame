using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player
    {
        private IPlayerBehavior _playerBehavior;

        public void SetPlayerBehavior(IPlayerBehavior pb)
        {
            _playerBehavior = pb;
        }

        public void ShowCards()
        {
            
        }
    }
}
/*
 *
 * for (short i = 0; i < numberOfPlayers; i++)
            {
                Card[] cards = new Card[numberOfCards];
                for (short j = 0; j < numberOfCards; j++)
                {
                    cards[j] = new Card();
                    Console.WriteLine(cards[i].Suit);
                }
                Console.WriteLine();
            }
 *
 */
