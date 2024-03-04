using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level31_TheFountainOfObjects
{
    public class FountainOfObjectsGame
    {
        public Map Map { get; }
        public Player Player { get; }

        public FountainOfObjectsGame()
        {
            Map = new Map();
            Player = new Player([0, 0]);
        }

        public void RunGame()
        {
            while (!HasWon())
            {
                Console.WriteLine("---------------------------------------------------------------------------------");
                DisplayCurrentStatus();
                GetPlayersAction();
            }
            ConsoleChanger.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!", ConsoleColor.Magenta);
            ConsoleChanger.WriteLine("You win!", ConsoleColor.Magenta);
        }

        public void GetPlayersAction()
        {
            int[] location = this.Player.Location;
            while (true)
            {
                ConsoleChanger.Write("What do you want to do? ", ConsoleColor.Cyan);
                string? input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "move east":
                        new MoveAction(Directions.East).OnAction(this);
                        break;
                    case "move west":
                        new MoveAction(Directions.West).OnAction(this);
                        break;
                    case "move north":
                        new MoveAction(Directions.North).OnAction(this);
                        break;
                    case "move south":
                        new MoveAction(Directions.South).OnAction(this);
                        break;
                    case "enable fountain":
                        new EnableFountain().OnAction(this);
                        break;
                    default:
                        Console.WriteLine("Invalid command!"); 
                        break;
                }
                break;
            }


        }
        private void DisplayCurrentStatus()
        {
            ConsoleChanger.WriteLine($"You are in the room at (Row={Player.Location[0]}, Column={Player.Location[1]})", ConsoleColor.White);
            Map.GetRoomType(Player.Location).Sense(); //If the room has a sense to display, it will be showed on the screen

        }


        public bool HasWon()
        {
            //probably could optimize this, but im trying generalize the game, so the FountaimRoom could be any position in the Map
            if (Map.GetRoomType(Player.Location) is EntranceRoom)
            {
                for (int row = 0; row < Map.Rows; row++)
                    for (int col = 0; col < Map.Columns; col++)
                    {
                        if (Map.GetRoomType([row, col]) is FountainRoom fountain)
                            if (fountain.IsFountainOn()) return true;
                    }
            }
            return false;
        }
    }
}
