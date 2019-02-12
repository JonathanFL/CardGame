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

        public List<Card> CardList = new List<Card>();

        private short _numberOfCards = 0;// value is used in derived classes

        private IPlayerBehavior _playerBehavior;

        public Player(string name, short numberOfCards)
        {
            Name = name;
            _numberOfCards = numberOfCards;
        }

        public void SetPlayerBehavior(IPlayerBehavior playerBehavior)// don't know what to do with this...
        {
            _playerBehavior = playerBehavior;
            //throw new NotImplementedException("Not sure how to implement this behaviour in my current design");
        }

        public void AcceptCard()
        {
            //Console.WriteLine("Base class AcceptCard() - does nothing");
            _playerBehavior.AcceptCard();
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

        public int ValueOfHand()
        {
            int sumOfHand = 0;
            foreach (var card in CardList)
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
