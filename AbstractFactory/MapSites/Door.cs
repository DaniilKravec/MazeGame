using System;

namespace AbstractFactory.MapSites
{
    public class Door : MapSite
    {
        private readonly Room _room1;
        private readonly Room _room2;
        private bool _isOpen;

        public Door(Room room1, Room room2)
        {
            _room1 = room1 ?? throw new ArgumentNullException(nameof(room1));
            _room2 = room2 ?? throw new ArgumentNullException(nameof(room2));
            _isOpen = false;
        }

        public void Open() => _isOpen = true;

        public Room OtherSideFrom(Room room)
        {
            if (room == null)
                throw new ArgumentNullException(nameof(room));
            return room == _room1 ? _room2 : _room1;
        }

        public override void Enter()
        {
            if (_isOpen)
                Console.WriteLine("Вы прошли через дверь.");
            else
                Console.WriteLine("Дверь закрыта.");
        }
    }
}
