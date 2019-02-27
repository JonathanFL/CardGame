using System;

namespace CardGame
{
    class Program
    {
        //public static short NumberOfCards { get; set; }
        //private static string Name { get; set; }
        
        static void Main(string[] args)
        {
            var game1 = new Game(GameType.HighestWin);
            
            Player player1 = new Player(new NormalPlayer("Jonster", 5));
            Player player2 = new Player(new WeakPlayer("Gustav", 5));
            Player player3 = new Player(new NormalPlayer("Jonsemand", 5));
            
            player1.AcceptCard();
            player2.AcceptCard();
            player3.AcceptCard();

            player1.ShowCards();
            player1.ShowHandValue();

            player2.ShowCards();
            player2.ShowHandValue();

            player3.ShowCards();
            player3.ShowHandValue();

            game1.CalculateWinner(player1);
            game1.CalculateWinner(player2);
            game1.CalculateWinner(player3);
            
            Console.WriteLine($"\nThe winner is {game1.WinnerName} and have {game1.WinnerPoints} points. Congratulations!");

            Console.ReadLine();

        }
    }
}
