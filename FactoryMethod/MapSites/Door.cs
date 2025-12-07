using System;

namespace FactoryMethod.MapSites
{
    public class Door : MapSite
    {
        private readonly Room _r1;
        private readonly Room _r2;

        public Door(Room r1, Room r2)
        {
            this._r1 = r1 ?? throw new ArgumentNullException(nameof(r1));
            this._r2 = r2 ?? throw new ArgumentNullException(nameof(r2));
        }

        public override void Enter()
        {
            Console.WriteLine("Вы проходите через дверь.");
        }
    }
}
