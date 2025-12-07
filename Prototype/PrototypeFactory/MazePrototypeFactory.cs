using System;
using Prototype.MapSites;

namespace Prototype.PrototypeFactory
{
    public class MazePrototypeFactory
    {
        private readonly Room _roomProto;
        private readonly Wall _wallProto;
        private readonly Door _doorProto;

        public MazePrototypeFactory(Room roomProto, Wall wallProto, Door doorProto)
        {
            _roomProto = roomProto ?? throw new ArgumentNullException(nameof(roomProto));
            _wallProto = wallProto ?? throw new ArgumentNullException(nameof(wallProto));
            _doorProto = doorProto ?? throw new ArgumentNullException(nameof(doorProto));
        }

        public Room MakeRoom()
        {
            return _roomProto.Clone();
        }

        public Wall MakeWall()
        {
            return _wallProto.Clone();
        }

        public Door MakeDoor(Room r1, Room r2)
        {
            if (r1 == null)
            {
                throw new ArgumentNullException(nameof(r1));
            }
            if (r2 == null)
            {
                throw new ArgumentNullException(nameof(r2));
            }
            Door clone = _doorProto.Clone();
            clone.Initialize(r1, r2); 
            return clone;
        }
    }
}
