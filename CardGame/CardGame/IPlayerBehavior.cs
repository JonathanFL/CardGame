using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    interface IPlayerBehavior
    {
        //Handle different kinds of players - altså i Player klassen
        //Vi vil gerne have funktionaliteten:
        //IPlayerBehavior normalPlayer = new NormalPlayer();
        //eller
        //IPlayerBehavior weakPlayer = new WeakPlayer();
        int HoldCards(int numberOfCards);
    }
}
