using System;

namespace Prototype.MapSites
{
    public class Door : MapSite, IPrototype<Door>
    {
        private Room _room1;
        private Room _room2;

        public Door()
        {
        }

        public Door(Room r1, Room r2)
        {
            Initialize(r1, r2);
        }

        
        public void Initialize(Room r1, Room r2)
        {
            _room1 = r1 ?? throw new ArgumentNullException(nameof(r1));
            _room2 = r2 ?? throw new ArgumentNullException(nameof(r2));
        }

        
        public Door Clone()
        {
            Door copy = new Door();
           
            copy._room1 = this._room1;
            copy._room2 = this._room2;
            return copy;
        }

        public override void Enter()
        {
            Console.WriteLine("Вы прошли через клонированную дверь.");
        }
    }
}

