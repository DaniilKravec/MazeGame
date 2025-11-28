using Prototype.MapSites;
using Prototype.PrototypeLogic;

namespace Prototype.Factory
{
    public class MazePrototypeFactory
    {
        private readonly Room _roomProto;
        private readonly Wall _wallProto;
        private readonly Door _doorProto;

        public MazePrototypeFactory(Room room, Wall wall, Door door)
        {
            this._roomProto = room;
            this._wallProto = wall;
            this._doorProto = door;
        }

        public Room MakeRoom() => this._roomProto.Clone();
        public Wall MakeWall() => this._wallProto.Clone();
        public Door MakeDoor(Room r1, Room r2) => new Door(r1, r2);
    }
}
