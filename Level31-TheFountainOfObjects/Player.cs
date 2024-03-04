using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level31_TheFountainOfObjects
{
    public class Player
    {
        public int[] Location { get; set; } = new int[2];
        public bool IsAlive { get; private set; }
        public Player(int[] start)
        {
            Location = start;
            IsAlive = true;
        }
    }

}
