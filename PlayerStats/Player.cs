using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;

        public string Name { get; }

        public float HighScore
        {
            get => highScore;
            set
            {
                if (value > highScore)
                    highScore = value;
            }
        }

        public float WinRate
        {
            get
            {
                if (playedGames == 0)
                    return 0f;
                
                return (float) wonGames / playedGames;
            }
        }

        public void PlayGame(bool win)
        {
            playedGames++;
            if (win)
                wonGames++;
        }

        public Player(string name)
        {
            Name = name;
            highScore = 0f;
            playedGames = 0;
            wonGames = 0;
        }

        public override string ToString()
        {
            return $"Player(Name:{Name}, HighScore:{HighScore}, Played:{playedGames}, Won:{wonGames}, WinRate:{WinRate})";
        }
    }
}