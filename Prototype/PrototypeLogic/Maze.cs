using System.Linq;
using Prototype.MapSites;
using System.Collections.Generic;

namespace Prototype.PrototypeLogic
{
    public class Maze
    {
        private readonly List<Room> rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public Room RoomNo(int number)
        {
            return rooms.First(r => r.Number == number);
        }

        public Maze Clone()
        {
            var m = new Maze();
            foreach (var room in rooms)
            m.AddRoom(room.Clone());
            return m;
        }
    }
}
