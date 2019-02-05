using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class NormalPlayer : Player
    {
        public NormalPlayer(string name, short numberOfCards) : base(name, numberOfCards)
        {
        }

        public override void AcceptCard()
        {
            short k = 0;
            while (k != NumberOfCards)
            {
                var c = new Card();
                _cardList.Add(c);
                k++;
            }
        }
        
    }
}
