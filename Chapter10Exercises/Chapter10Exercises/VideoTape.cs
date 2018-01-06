using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercises
{
    class VideoTape:Tape
    {
        private int playingTime;
        public int PlayingTime { get { return playingTime; } set { playingTime = value; } }

        public override string ToString()
        {
            return "Length: " + Length + "\tWidth:" + Width + "\tPLayingTime: "+PlayingTime;
        }
    }
}
