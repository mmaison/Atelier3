using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;
using SoccerRankingLib;

namespace SoccerRankingLib
{
    public abstract class PointSystem
    {

        public abstract ITotal InitialPoints { get; }

        public abstract ITotal GetPointsFromMatch(Match m, bool isHome);

   public interface ITotal
    {
         void Increment(ITotal with);
         int CompareTo(Object obj);

       //override string ToString;
        
       
    }

      }
}
