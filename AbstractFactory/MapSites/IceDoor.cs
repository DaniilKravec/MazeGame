using System;

namespace AbstractFactory.MapSites
{
    public class IceDoor : Door
    {
        public IceDoor(Room room1, Room room2) : base(room1, room2) { }

        public override void Enter()
        {
            Console.WriteLine("Вы прошли через ледяную дверь.");
        }
    }
}
