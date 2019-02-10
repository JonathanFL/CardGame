using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class WeakPlayer : Player
    {
        private static readonly Random RndCardNumber = new Random();

        private readonly short _numberOfCards;

        public WeakPlayer(string name, short numberOfCards) : base(name, numberOfCards)
        {
            _numberOfCards = numberOfCards;
        }

        public override void AcceptCard()
        {
            short k = 0;
            while (k != _numberOfCards)
            {
                var c1 = new Card();
                CardList.Add(c1);
                k++;
                if (CardList.Count.Equals(4))
                {
                    CardList.RemoveAt(RndCardNumber.Next(1, 4));
                }
            }
        }
    }
}
