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

            if ((ScoreOne == 40 || ScoreOne == 50) && (ScoreTwo == 40)
                || (ScoreTwo == 40 || ScoreTwo == 50) && (ScoreOne == 40))
            {
                //For 40-40 or 40-50 or 50-40 return Deuce
                result = "Deuce";
            }
            else if(ScoreOne >= 50)
            {
                if(ScoreTwo == 30 && ScoreOne != 60)
                {
                    //Only for 50-30 return Advantage server
                    result = "Advantage server";
                }
                else
                {
                    //Return win for 50-0 or 50-15 or 60-30
                    result = "Server wins game";
                }
            }
            else if(ScoreTwo >= 50)
            {
                if(ScoreOne == 30 && ScoreTwo != 60)
                {
                    //Only for 30-50 return Advantage non-server
                    result = "Advantage non-server";
                }
                else
                {
                    //Return loss for 0-50 or 15-50 or 30-60
                    result = "Server loses game";
                }
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
