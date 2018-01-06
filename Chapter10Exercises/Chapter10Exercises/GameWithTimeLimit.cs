using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercises
{
    class GameWithTimeLimit: Game
    {
        private int timeLimit;
        public int TimeLimit { get { return timeLimit; } set{ timeLimit = value; } }

        public override string ToString()
        {
            return "Class:" + this.GetType() + " Name:" + this.Name + " NumberOfPlayers:" + MaximumPlayers + " TimeLimit:" +TimeLimit;
        }
    }
}
