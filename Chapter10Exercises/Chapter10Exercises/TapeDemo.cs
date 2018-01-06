using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercises
{
    class TapeDemo
    {
        public static void Run(string[] args)
        {
            Tape tape = new Tape();
            tape.Length = 10;
            tape.Width = 10;
            Console.WriteLine(tape.ToString());

            VideoTape videoTape = new VideoTape();
            videoTape.Length = 20;
            videoTape.Width = 20;
            Console.WriteLine(videoTape.ToString());

            AdhesiveTape adhesiveTape = new AdhesiveTape();
            adhesiveTape.Length = 30;
            adhesiveTape.Width = 30;
            Console.WriteLine(adhesiveTape.ToString());
        }
    }
}
