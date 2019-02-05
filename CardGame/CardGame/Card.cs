using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        public short Multiplier { get; set; }
        public int CardNumber { get; set; }
        public string Suit { get; set; }
        private static readonly Random RndMultiPlier = new Random();
        private static readonly Random RndCardNumber = new Random();

        public Card()
        {
            Multiplier = (short) RndMultiPlier.Next(1, 5);
            CardNumber = RndCardNumber.Next(1, 9);
            Suit = DetermineColor(Multiplier) + " " + CardNumber;
        }
        
        private string DetermineColor(short multiplier)
        {
            switch (multiplier)
            {
                case 1:
                    return "Red";
                case 2:
                    return "Blue";
                case 3:
                    return "Green";
                case 4:
                    return "Yellow";
                default:
                    return "Blank";
            }
        }
    }
}
