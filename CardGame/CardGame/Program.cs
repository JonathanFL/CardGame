using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
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
                    else
                    {
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
                                players[i] = new Player();
                                players[i].SetPlayerBehavior(new NormalPlayer());
                            }
                            else if (playerType != null && (playerType.Equals("No") || playerType.Equals("no")))
                            {
                                players[i] = new Player();
                                players[i].SetPlayerBehavior(new WeakPlayer());
                            }
                            else
                            {
                                throw new ArgumentException("You didn't input yes or no");
                            }
                        }

                        Deck testDeck = new Deck(players);
                    }
                }
                else
                {
                    Console.WriteLine("Number of players must only be maximum 32,767 and only contain integer value");
                }
            }

        }
    }
}
