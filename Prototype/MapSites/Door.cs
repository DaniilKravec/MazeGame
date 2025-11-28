using System;

namespace Prototype.MapSites
{
    public class Door : MapSite, IPrototype<Door>
    {
        private readonly Room _room1;
        private readonly Room _room2;

        public Door(Room r1, Room r2)
        {
            this._room1 = r1 ?? throw new ArgumentNullException(nameof(r1));
            this._room2 = r2 ?? throw new ArgumentNullException(nameof(r2));
        }

        private Door(Room r1, Room r2, bool clone)
        {
            this._room1 = r1;
            this._room2 = r2;
        }

        public Door Clone()
        {
            return new Door(this._room1, this._room2, true);
        }

        public override void Enter()
        {
            Console.WriteLine("Вы вошли через клонированную дверь.");
        }
    }
}