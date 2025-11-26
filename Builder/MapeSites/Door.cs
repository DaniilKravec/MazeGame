using System;

namespace Builder.MapSites
{
    public class Door : MapSite
    {
        private readonly Room _room1;
        private readonly Room _room2;
        private bool _isOpen;

        public Door(Room room1, Room room2)
        {
            this._room1 = room1 ?? throw new ArgumentNullException(nameof(room1));
            this._room2 = room2 ?? throw new ArgumentNullException(nameof(room2));
        }

        public void Open() => this._isOpen = true;

        public Room OtherSideFrom(Room room)
        {
            if (room == null)
                throw new ArgumentNullException(nameof(room));
            return room == this._room1 ? this._room2 : this._room1;
        }

        public override void Enter()
        {
            if (this._isOpen)
                Console.WriteLine("Вы прошли через дверь.");
            else
                Console.WriteLine("Дверь закрыта.");
        }
    }
}

