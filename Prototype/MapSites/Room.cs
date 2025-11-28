using System;

namespace Prototype.MapSites
{
    public class Room : MapSite, IPrototype<Room>
    {
        private readonly int _number;

        public Room(int number)
        {
            if (number <= 0)
                throw new ArgumentException(nameof(number));
            this._number = number;
        }

        public int Number => this._number;

        public Room Clone()
        {
            return new Room(this._number);
        }

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в клонированную комнату №{this._number}");
        }
    }
}