using Prototype.MapSites;
using System;
using System.Collections.Generic;

namespace Prototype.PrototypeLogic
{
    public class Maze : IPrototype<Maze>
    {
        private readonly List<Room> _rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            if (room == null)
                throw new ArgumentNullException(nameof(room));
            this._rooms.Add(room);
        }

        public Maze Clone()
        {
            Maze clone = new Maze();
            foreach (var room in this._rooms)
            {
                clone.AddRoom(room.Clone());
            }
            return clone;
        }
    }
}
