using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class WeakPlayer : IPlayerBehavior
    {
        private static readonly Random RndCardNumber = new Random();
        public List<Card> CardList = new List<Card>();
        public string Name { get; set; }
        public int NumberOfCards { get; set; }

        public WeakPlayer(string name, short numberOfCards)
        {
            Name = name;
            NumberOfCards = numberOfCards;
        }

        public void AcceptCard()
        {
            short k = 0;
            while (k != NumberOfCards)
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

        public int ValueOfHand()
        {
            int sumOfHand = 0;
            foreach (var card in CardList)
            {
                sumOfHand += card.Multiplier * card.CardNumber;
            }

            return sumOfHand;
        }

        public void ShowValueOfHand()
        {
            Console.WriteLine($"The hand value of {Name} is: {ValueOfHand()}");
        }

        public void ShowHandValue()
        {
            Console.WriteLine($"The hand value of {Name} is: {ValueOfHand()}");
        }

        public void ShowCards()
        {
            Console.WriteLine("\n" + Name + ":");
            for (short j = 0; j < CardList.Count; j++)
            {
                Console.WriteLine(CardList.ElementAt(j).Suit);
            }
            Console.WriteLine();
        }

    }
}
