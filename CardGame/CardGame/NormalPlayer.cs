using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class NormalPlayer : IPlayerBehavior
    {

        public List<Card> CardList = new List<Card>();
        public string Name { get; set; }
        public int NumberOfCards { get; set; }

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

        public NormalPlayer(string name, short numberOfCards)
        {
            Name = name;
            NumberOfCards = numberOfCards;
        }

        public void AcceptCard()
        {
            short k = 0;
            while (k != NumberOfCards)
            {
                var c = new Card();
                CardList.Add(c);
                k++;
            }
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
