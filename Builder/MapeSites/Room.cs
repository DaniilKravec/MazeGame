using System;
using System.Collections.Generic;

namespace Builder.MapSites
{
    public class Room : MapSite
    {
        private readonly int _number;
        private readonly Dictionary<string, MapSite> _sides = new Dictionary<string, MapSite>();

        public Room(int number)
        {
            if (number <= 0)
                throw new ArgumentException("Номер комнаты должен быть положительным.");
            this._number = number;
        }

        public int Number => this._number;

        public void SetSide(string direction, MapSite site)
        {
            if (site == null)
                throw new ArgumentNullException(nameof(site));
            this._sides[direction] = site;
        }

        public MapSite GetSide(string direction)
        {
            return this._sides.TryGetValue(direction, out var side) ? side : null;
        }

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в комнату №{this._number}");
        }
    }
}