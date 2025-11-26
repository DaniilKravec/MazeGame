using System;
using System.Collections.Generic;

namespace AbstractFactory.MapSites
{
    public class Room : MapSite
    {
        private readonly int _number;
        private readonly Dictionary<int, MapSite> _sides = new Dictionary<int, MapSite>();

        public Room(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть положительным.");
            }
            _number = number;
        }

        public int Number => _number;

        public void SetSide(int direction, MapSite site)
        {
            if (site == null)
            {
                throw new ArgumentNullException(nameof(site));
            }
            _sides[direction] = site;
        }

        public MapSite GetSide(int direction)
        {
            return _sides.TryGetValue(direction, out var side) ? side : null;
        }

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в комнату №{_number}");
        }
    }
}
