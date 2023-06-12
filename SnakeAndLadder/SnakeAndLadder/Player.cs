using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Player
    {
        public int StartPoint = 0;
        public void StartPlaying()
        {
            Console.WriteLine("Game started");
            Console.WriteLine("you are at " + StartPoint);
        }
    }
}
