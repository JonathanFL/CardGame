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
        public int Winner { get; set; }

        private static GameType _gameType;

        private bool helpVar = false;

        public Game(GameType gameType)
        {
            _gameType = gameType;
        }

        public void CalculateWinner(int cardValue)
        {
            if (_gameType.Equals(GameType.HighestWin))
            {
                if (cardValue > Winner)
                {
                    Winner = cardValue;
                }
            }else if (_gameType.Equals(GameType.LowestWin))
            {
                if (helpVar == false)
                {
                    helpVar = true;
                    Winner = cardValue;
                }
                if (cardValue < Winner)
                {
                    Winner = cardValue;
                }
            }
        }
        
    }
}
