using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level31_TheFountainOfObjects
{
    public class EntranceRoom : Room
    {
        public override void Sense()
        {
            ConsoleChanger.WriteLine("You see light in this room coming from outside the cavern. This is the entrance", ConsoleColor.Yellow);
        }
    }
}
