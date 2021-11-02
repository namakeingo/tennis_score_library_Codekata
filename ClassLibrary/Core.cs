using System;

namespace ClassLibrary
{
    public class Core
    {
        private int ScoreOne { get; set; }
        private int ScoreTwo { get; set; }

        public string GetScore()
        {
            string result = "";

            if (ScoreOne == 40 && ScoreTwo == 40
                || ScoreOne == 50 && ScoreTwo == 40
                || ScoreOne == 40 && ScoreTwo == 50)
            {
                result = "Deuce";
            }
            else if (ScoreOne == 50)
            {
                if (ScoreTwo < 30)
                {
                    result = "Server wins game";
                }
                else
                {
                    result = "Advantage server";
                }
            }
            else if (ScoreTwo == 50)
            {
                if (ScoreOne < 30)
                {
                    result = "Server loses game";
                }
                else
                {
                    result = "Advantage non-server";
                }
            }
            else if (ScoreOne == 60 && ScoreTwo == 30)
            {
                result = "Server wins game";
            }
            else if (ScoreOne == 30 && ScoreTwo == 60)
            {
                result = "Server loses game";
            }
            else
            {
                //For not endgame score format points as {0}-{1}
                result = string.Format("{0}-{1}", ScoreOne, ScoreTwo);
            }
            return result;
        }

        /// <summary>
        /// Add a score to player one total points
        /// </summary>
        public void PlayerOneScore()
        {
            ScoreOne = ScoreOne >= 30 ? (ScoreOne + 10) : (ScoreOne + 15);
        }

        /// <summary>
        /// Add a score to player two total points
        /// </summary>
        public void PlayerTwoScore()
        {
            ScoreTwo = ScoreTwo >= 30 ? (ScoreTwo + 10) : (ScoreTwo + 15);
        }
    }
}
