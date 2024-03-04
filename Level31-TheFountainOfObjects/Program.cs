using Level31_TheFountainOfObjects;
using System.Numerics;

FountainOfObjectsGame teste = new();
teste.RunGame();

public interface IAction
{
   void OnAction(FountainOfObjectsGame game);
}

public class EnableFountain : IAction
{
    public void OnAction(FountainOfObjectsGame game)
    {
        Room room = game.Map.GetRoomType(game.Player.Location);
        if (room is FountainRoom fountainRoom)
        {
            if(!fountainRoom.IsFountainOn())
                fountainRoom.FountainState = true;
            else
                ConsoleChanger.WriteLine("Fountain already activated", ConsoleColor.DarkBlue);
        }
        else
        {
            ConsoleChanger.WriteLine("You're not in the Fountain Room!", ConsoleColor.DarkBlue);
        }
    }
}
public class MoveAction : IAction
{
    private Directions _direction;

    public MoveAction(Directions direction)
    {
        _direction = direction;
    }

    public void OnAction(FountainOfObjectsGame game)
    {
        int[] currentLocation = game.Player.Location;
        int[] nextLocation;

        nextLocation = _direction switch
        {
            Directions.North => [currentLocation[0] - 1, currentLocation[1]],
            Directions.South => [currentLocation[0] + 1, currentLocation[1]],
            Directions.West => [currentLocation[0], currentLocation[1] - 1],
            Directions.East => [currentLocation[0], currentLocation[1] + 1],
        };
        if (game.Map.IsOnMap(nextLocation))
        {
            game.Player.Location = nextLocation;
        }
        else
        {
            ConsoleChanger.WriteLine("You cannot move there! Try another position!", ConsoleColor.Red);
        }

    }
}
public enum Directions { North, South, West, East}