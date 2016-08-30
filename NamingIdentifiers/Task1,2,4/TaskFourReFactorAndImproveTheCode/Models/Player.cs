namespace Minesweeper.Models
{
    using System;

    public class Player
    {
        private string playerName;
        private int pointsPerPlayer;

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name
        {
            get
            {
                return this.playerName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                this.playerName = value;
            }
        }

        public int Points
        {
            get
            {
                return this.pointsPerPlayer;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Points cannot be negative number!");
                }

                this.pointsPerPlayer = value;
            }
        }
    }
}
