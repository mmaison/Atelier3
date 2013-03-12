using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public class Match
    {
       private int goals;
       private int hgoals;
       private Club home;
       private Club away;
       private bool isHomeForfeit;
       private bool isAwayForfeit;
       private bool isDraw;

       public Match(Club leClub, String leType)
       {
           if (leType.Equals("home"))
                this.home = leClub;
           else
                this.away = leClub;
       }

       public Match(int leClubGoal, String leType)
       {
           if (leType.Equals("home"))
               this.hgoals = leClubGoal;
           else
               this.goals = leClubGoal;
       }

        public Match(Club home, Club away, bool isForfeit, string whoIsForfeit)
        {
            this.home = home;
            this.away = away;

            if(whoIsForfeit.Equals("home"))
                  this.isHomeForfeit = isForfeit;
            else if (whoIsForfeit.Equals("away"))
                this.isAwayForfeit = isForfeit;
            else
            {
                this.isHomeForfeit = isForfeit;
                this.isAwayForfeit = isForfeit;
            }
        }



        public Match(Club home, Club away, int hgoals, int goals)
        {
            this.home = home;
            this.away = away;
            this.hgoals = hgoals;
            this.goals = goals;
        }

        public Club Away
        {
            get
            {
                return away;
            }
        }

        public int AwayGoals
        {
            get
            {
                return goals;
            }
        }

        public Club Home
        {
            get
            {
                return home;
            }
        }

        public int HomeGoals
        {
            get
            {
                return hgoals;
            }
        }

        public bool IsAwayForfeit
        {
            get
            {
                return isHomeForfeit;
            }
        }

        public bool IsDraw
        {
            get
            {
                return isDraw = (hgoals == goals);
            }
        }

        public bool IsHomeForfeit
        {
            get
            {
                return isHomeForfeit;
            }
        }

    }
}
