using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercises
{
    class Game
    {
        private string name;
        private int maximumPlayers;
        public string Name { get { return name; } set { name = value; } }
        public int MaximumPlayers { get { return maximumPlayers; } set { maximumPlayers = value; } }

        public override string ToString()
        {
            return "Class:" +this.GetType() +" Name:" + this.Name + " NumberOfPlayers:" +MaximumPlayers;
        }
    }
}
