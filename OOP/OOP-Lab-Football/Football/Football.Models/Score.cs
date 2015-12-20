using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Models
{
    class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score(int awayTeamGoals, int homeTeamGoals)
        {
            this.AwayTeamGoals = awayTeamGoals;
            this.HomeTeamGoals = homeTeamGoals;
        }
            
        public int HomeTeamGoals
            {
                get
                {
                    return this.homeTeamGoals;
                }
                set 
                {
                    if(value < 0)
                    {
                        throw new ArgumentException ("Goals cannot be negative ");
                    }
                    this.homeTeamGoals = value;
                }
            }

            public int AwayTeamGoals 
            {
                get
                {
                    return this.awayTeamGoals;
                }
                set
                {
                    if(value < 0)
                    {
                        throw new ArgumentException ("Goals cannot be negative");
                    }
                    this.awayTeamGoals = value;
                }
            }
    }
}




