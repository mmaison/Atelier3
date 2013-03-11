using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;
using Atelier3;

namespace SoccerRankingLib 
{
    class FrenchLeague1PointSystem : PointSystem
    {
        private static FrenchLeague1PointSystem theInstance;

        public override PointSystem.ITotal InitialPoints
        {
            get { return new PointTotal(); }
        }

        public static PointSystem Instance
        {
            get
            {
                if (theInstance == null)
                    theInstance = new FrenchLeague1PointSystem();

                return theInstance;
            }
        }

        public override PointSystem.ITotal GetPointsFromMatch(Match m, bool isHome)
        {
            return new PointTotal(m,isHome);
        }

        public class PointTotal : ITotal
        {
            private int goalaverage;
            private int points;

            #region ITotal Membres
            public int CompareTo(Object obj)
            {
                return this.points - (int)obj;
            }

            public void Increment(ITotal with)
            {
                this.points += ((PointTotal)with).points;
            }

            public PointTotal()
            {
                this.points = 0; //todo verifier
            }

            public PointTotal(Match m, bool home)
            {
                if (home)
                   this.points = (m.HomeGoals);
                else
                    this.points = (m.AwayGoals);
            }

            public override string ToString()
            {
                return base.ToString();
            }
            #endregion
        }
    }


}
