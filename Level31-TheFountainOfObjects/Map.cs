using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level31_TheFountainOfObjects
{
    public class Map
    {
        private readonly Room[,] _rooms;
        public int Rows { get; private set; } = 4;
        public int Columns { get; private set; } = 4;

        public Map()
        {
            _rooms = new Room[Rows, Columns];
            for (int row = 0; row < Rows; row++)
                for (int col = 0; col < Columns; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        _rooms[row, col] = new EntranceRoom();
                    }
                    else if (row == 0 && col == 2)
                    {
                        _rooms[row, col] = new FountainRoom();
                    }
                    else _rooms[row, col] = new EmptyRoom();
                }
        }

        public Room GetRoomType(int[] coordinate) => _rooms[coordinate[0], coordinate[1]];
        public bool IsOnMap(int[] coordinate)
        {
            if (coordinate[0] < 0 || coordinate[0] > 3) return false;
            if (coordinate[1] < 0 || coordinate[1] > 3) return false;
            return true;
        }
    }
}
