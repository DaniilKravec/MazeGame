using System;

namespace Prototype.MapSites
{
    public class Room : MapSite, IPrototype<Room>
    {
        private int _number;

        public Room()
        {
        }

        public Room(int number)
        {
            Initialize(number);
        }

        
        public void Initialize(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException(nameof(number));
            }
            _number = number;
        }

        public int Number => _number;

        public Room Clone()
        {
            Room copy = new Room();
            copy.Initialize(_number);
            return copy;
        }

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в клонированную комнату №{_number}");
        }
    }
}
