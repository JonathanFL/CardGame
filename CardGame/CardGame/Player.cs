using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player : IPlayerBehavior
    {
        public string Name { get; set; }

        public readonly List<Card> _cardList = new List<Card>();
        private static readonly Random RndCardNumber = new Random();

        public short NumberOfCards { get; set; }

        public Player(string name, short numberOfCards)
        {
            Name = name;
            NumberOfCards = numberOfCards;
        }

        public virtual void AcceptCard()
        {
            short k = 0;
            while (k != NumberOfCards)
            {
                var c = new Card();
                _cardList.Add(c);
                k++;
            }
        }

        public void ShowCards()
        {
            Console.WriteLine("\n" + Name + ":");
            for (short j = 0; j < _cardList.Count; j++)
            {
                Console.WriteLine(_cardList.ElementAt(j).Suit);
            }
            Console.WriteLine();
        }

        public int ValueOfHand()
        {
            int sumOfHand = 0;
            foreach (var card in _cardList)
            {
                sumOfHand += card.Multiplier * card.CardNumber;
            }

            return sumOfHand;
        }

        public void ShowHandValue()
        {
            Console.WriteLine($"The hand value of {Name} is: {ValueOfHand()}");
        }
    }
}
