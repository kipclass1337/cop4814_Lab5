game.cs file was added during step 7 of this lab in the Branch_1 branch.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Game
    {
        public String team1, team2;
        public int team1Score, team2Score;

        public Game()
        {

        }

        public Game(String team1, String team2, int team1Score, int team2Score)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.team1Score = team1Score;
            this.team2Score = team2Score;
        }

        public override string ToString()
        {
            return team1 + "(" + team1Score + ") -- " + team2 + "(" + team2Score + ")";
        }
    }
}
