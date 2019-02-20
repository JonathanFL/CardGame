using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{

    public enum GameType
    {
        HighestWin = 1,
        LowestWin = 2
    }

    class Game
    {
        public int WinnerPoints { get; set; }
        public string WinnerName { get; set; }

        private static GameType _gameType;

        private bool _helpVar = false;

        public Game(GameType gameType)
        {
            _gameType = gameType;
        }

        public void CalculateWinner(Player lpl)
        {
            switch (_gameType)
            {
                case GameType.HighestWin:
                    if (lpl.ValueOfHand() > WinnerPoints)
                    {
                        WinnerPoints = lpl.ValueOfHand();
                        WinnerName = lpl.Name;

                    }
                    break;
                case GameType.LowestWin:
                    if (_helpVar == false)
                    {
                        _helpVar = true;
                        WinnerPoints = lpl.ValueOfHand();
                        WinnerName = lpl.Name;
                    }
                    if (lpl.ValueOfHand() < WinnerPoints)
                    {
                        WinnerPoints = lpl.ValueOfHand();
                        WinnerName = lpl.Name;
                    }
                    break;
            }
        }
        
    }
}
