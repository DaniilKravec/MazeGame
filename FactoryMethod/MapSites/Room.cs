using System;

namespace FactoryMethod.MapSites
{
    public class Room : MapSite
    {
        private readonly int _number;

        public Room(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException(nameof(number));
            }
            this._number = number;
        }

        public int Number => this._number;

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в комнату №{this._number}");
        }
    }
}
