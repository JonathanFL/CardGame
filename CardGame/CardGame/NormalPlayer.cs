using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class NormalPlayer : Player, IPlayerBehavior
    {
        private readonly short _numberOfCards;
        public NormalPlayer(string name, short numberOfCards) : base(name, numberOfCards)
        {
            _numberOfCards = numberOfCards;
        }

        public new void AcceptCard()
        {
            short k = 0;
            while (k != _numberOfCards)
            {
                var c = new Card();
                CardList.Add(c);
                k++;
            }
        }

        
    }
}
