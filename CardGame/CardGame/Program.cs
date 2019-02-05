using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        public static short NumberOfCards { get; set; }
        private static string Name { get; set; }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to a game of cards!");
                Console.WriteLine("How many players will be joining?");
                short _numberOfPlayers;
                if (short.TryParse(Console.ReadLine(), out _numberOfPlayers))
                {
                    if (_numberOfPlayers <= 0)
                    {
                        throw new Exception("Number must be positive and non zero");
                    }
                    Console.WriteLine("How many cards should everyone have?");
                        short _numberOfCards = 0;
                        if (short.TryParse(Console.ReadLine(), out _numberOfCards))
                        {
                            NumberOfCards = _numberOfCards;
                        }
                        
                        Player[] players = new Player[_numberOfPlayers];

                        Console.WriteLine("The game can have normal and \"weak\" players\n");
                        for (int i = 0; i < _numberOfPlayers; i++)
                        {
                            string playerType = " ";
                            Console.WriteLine("Is player" + i + " normal player?");
                            Console.WriteLine("Type \"yes\" for agreeing or \"no\" if player" + i + " is a weak player");
                            playerType = Console.ReadLine();
                            if (playerType != null && (playerType.Equals("yes") || playerType.Equals("Yes")))
                            {
                                Console.WriteLine("What is the name of player" + i + " ?");
                                Name = Console.ReadLine();
                                players[i] = new NormalPlayer(Name, NumberOfCards);
                                players[i].AcceptCard();
                        }
                            else if (playerType != null && (playerType.Equals("No") || playerType.Equals("no")))
                            {
                                Console.WriteLine("What is the name of player" + i + " ?");
                                Name = Console.ReadLine();
                                players[i] = new WeakPlayer(Name, NumberOfCards);
                                players[i].AcceptCard();
                            }
                            else
                            {
                                throw new ArgumentException("You didn't input yes or no");
                            }
                        }
                        Game game = new Game();

                        foreach (var p in players)
                        {
                            p.ShowCards();
                            p.ShowHandValue();
                            game.CalculateWinner(p.ValueOfHand());
                        }
                        Console.WriteLine($"\n\nThe winner has {game.Winner} points... CONGRATULATIONS!");
                    }
                else
                {
                    Console.WriteLine("Number of players must only be maximum 32,767 and only contain integer value");
                }
            }

        }
        
    }
}
