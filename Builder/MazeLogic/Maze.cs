using System.Collections.Generic;
using System.Linq;
using Builder.MapSites;

namespace Builder.MazeLogic
{
    public class Maze
    {
        private readonly List<Room> _rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            if (room == null)
                throw new System.ArgumentNullException(nameof(room));

            if (this._rooms.Any(r => r.Number == room.Number))
                throw new System.ArgumentException("Комната с таким номером уже существует.");

            this._rooms.Add(room);
        }

        public Room RoomNo(int number)
        {
            return this._rooms.FirstOrDefault(r => r.Number == number);
        }

        public IReadOnlyList<Room> Rooms => this._rooms.AsReadOnly();
    }
}
