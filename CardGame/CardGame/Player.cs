using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Player
    {
        public string Name { get; set; }
        public IPlayerBehavior PlayerBehavior { get; }

        public Player(IPlayerBehavior player)
        {
            PlayerBehavior = player;
            Name = PlayerBehavior.Name;
        }

        public void AcceptCard()
        {
            PlayerBehavior.AcceptCard();
        }

        public void ShowCards()
        {
            PlayerBehavior.ShowCards();
        }

        public int ValueOfHand()
        {
            return PlayerBehavior.ValueOfHand();
        }

        public void ShowHandValue()
        {
            PlayerBehavior.ShowValueOfHand();
        }
    }
}
