using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercises
{
    class Tape
    {
        private int length;
        private int width;
        public int Length { get { return length; } set { length = value; } }
        public int Width { get { return width; } set { width = value; } }

        public override string ToString()
        {
            return "Length: " + Length + "\tWidth:" + Width;
        }
    }
}
