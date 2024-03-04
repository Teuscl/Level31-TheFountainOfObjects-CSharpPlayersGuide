using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level31_TheFountainOfObjects
{
    public class FountainRoom : Room
    {
        //By default, is off(false)
        public bool FountainState { get; set; }

        public bool IsFountainOn() => FountainState;

        public override void Sense()
        {
            if (!IsFountainOn())
                ConsoleChanger.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!",ConsoleColor.Blue);
            else 
                ConsoleChanger.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!", ConsoleColor.Blue);
        }
    }
}
