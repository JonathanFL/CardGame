using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    interface IPlayerBehavior
    {
        short NumberOfCards { get; set; }
        string Name { get;}
        void AcceptCard();
        void ShowCards();
        int ValueOfHand();
        void ShowHandValue();
    }
}
