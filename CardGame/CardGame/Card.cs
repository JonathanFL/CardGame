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
        public string Suit { get; set; }
        private static readonly Random rndMultiPlier = new Random();
        private static readonly Random rndCardNumber = new Random();

        public Card()
        {
            Multiplier = (short) rndMultiPlier.Next(1, 5);
            Suit = DetermineColor(Multiplier) + " " + rndCardNumber.Next(1, 9);
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
