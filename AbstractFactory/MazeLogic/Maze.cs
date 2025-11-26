using System;
using System.Collections.Generic;
using System.Linq;
using AbstractFactory.MapSites;

namespace AbstractFactory.MazeLogic
{
    public class Maze
    {
        private readonly List<Room> _rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            if (room == null)
            {
                throw new ArgumentNullException(nameof(room));
            }

            if (_rooms.Any(r => r.Number == room.Number))
            {
                throw new ArgumentException("Комната с таким номером уже существует.");
            }
            _rooms.Add(room);
        }

        public Room RoomNo(int number)
        {
            return _rooms.FirstOrDefault(r => r.Number == number);
        }

        public IReadOnlyList<Room> Rooms => _rooms.AsReadOnly();
    }
}
