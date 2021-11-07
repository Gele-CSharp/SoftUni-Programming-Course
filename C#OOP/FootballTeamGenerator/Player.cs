using System;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string playerName;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            PlayerName = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string PlayerName
        {
            get => playerName;

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                playerName = value;
            }
        }

        public int Endurance 
        {
            get => endurance;
            
            private set
            {
                ValidateValue(nameof(Endurance), value);
                endurance = value;
            }
        }

        public int Sprint
        {
            get => sprint;

            private set
            {
                ValidateValue(nameof(Sprint), value);
                sprint = value;
            }
        }


        public int Dribble
        {
            get => dribble;

            private set
            {
                ValidateValue(nameof(Dribble), value);
                dribble = value;
            }
        }

        public int Passing
        {
            get => passing;

            private set
            {
                ValidateValue(nameof(Passing), value);
                passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;

            private set
            {
                ValidateValue(nameof(Shooting), value);
                shooting = value;
            }
        }

        public int Stat => (int)Math.Round((Endurance + Sprint + Dribble + Passing + Shooting) / 5.0);
        

        private static void ValidateValue(string statName, int value)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{statName} should be between 0 and 100.");
            }
        }
    }
}
