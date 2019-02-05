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

        public WeakPlayer(string name, short numberOfCards) : base(name, numberOfCards)
        {
        }

        public override void AcceptCard()
        {
            short k = 0;
            while (k != NumberOfCards)
            {
                var c1 = new Card();
                _cardList.Add(c1);
                k++;
                if (_cardList.Count.Equals(4))
                {
                    _cardList.RemoveAt(RndCardNumber.Next(1, 4));
                }
            }
        }
    }
}
