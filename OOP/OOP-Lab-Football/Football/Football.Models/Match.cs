using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football.Models.Score;

namespace Football.Models
{
    class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }
            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals ? this.homeTeam : this.AwayTeam;
        }

        private bool IsDraw()
        {
            return this.Score.AwayTeamGoals = this.Score.HomeTeamGoals;
        }
    }
}
