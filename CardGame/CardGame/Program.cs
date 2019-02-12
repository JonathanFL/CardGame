using System;

namespace CardGame
{
    class Program
    {
        //public static short NumberOfCards { get; set; }
        //private static string Name { get; set; }

        private const int Cards = 4;

        static void AcceptCard(Player player)
        {
            player.AcceptCard();
        }

        static void ShowCards(Player player)
        {
            player.ShowCards();
        }

        static void ShowHandValue(Player player)
        {
            player.ShowHandValue();
        }

        static void Main(string[] args)
        {
            var game1 = new Game(GameType.HighestWin);

            Player pb = new Player("jons", Cards);
            Player pb2 = new WeakPlayer("jons2", Cards);
            Player pb3 = new NormalPlayer("Troels", Cards);
            Player pb4 = new NormalPlayer("Yibin",Cards);
            Player pb5 = new WeakPlayer("Jons", Cards);

            var test = new WeakPlayer("Jons", Cards);
            pb.SetPlayerBehavior(test);

            pb.AcceptCard();

            /*AcceptCard(pb2);
            AcceptCard(pb3);
            AcceptCard(pb4);
            AcceptCard(pb5);
            */
            ShowCards(pb);

            pb.SetPlayerBehavior(pb3);
            pb.AcceptCard();
            ShowCards(pb);

            // TODO
            ShowCards(pb2);
            ShowCards(pb3);
            ShowCards(pb4);
            ShowCards(pb5);

            ShowHandValue(pb);
            ShowHandValue(pb2);
            ShowHandValue(pb3);
            ShowHandValue(pb4);
            ShowHandValue(pb5);

            game1.CalculateWinner(pb.ValueOfHand());
            game1.CalculateWinner(pb2.ValueOfHand());
            game1.CalculateWinner(pb3.ValueOfHand());
            game1.CalculateWinner(pb4.ValueOfHand());
            game1.CalculateWinner(pb5.ValueOfHand());

            Console.WriteLine($"Winner: {game1.Winner}");

            Console.ReadLine();

            /*
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
                        Game game = new Game(GameType.HighestWin);

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
            }*/

        }
    }
}
