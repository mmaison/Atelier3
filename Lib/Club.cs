using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    
    public class Club
    {
        private string name;

        public Club(string name)
        {
            this.name = name;
        }
        
        public override string ToString()
        {
            return name;
        }
    }

  
}
