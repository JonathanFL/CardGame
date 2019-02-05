using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Game
    {
        public int Winner { get; set; }

        public void CalculateWinner(int cardValue)
        {
            if (Winner < cardValue)
            {
                Winner = cardValue;
            }
        }
    }
}
