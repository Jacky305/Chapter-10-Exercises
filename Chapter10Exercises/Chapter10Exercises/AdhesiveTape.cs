using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercises
{
    class AdhesiveTape:Tape
    {
        private int stickiness;
        public int Stickiness { get { return stickiness; } set {
                if (value < 1)
                    value = 1;
                if (value > 10)
                    value = 10;
                stickiness = value; }
        }

        public override string ToString()
        {
            return "Length: " + Length + "\tWidth:" + Width + "\tStickiness: " + stickiness;
        }
    }
}
