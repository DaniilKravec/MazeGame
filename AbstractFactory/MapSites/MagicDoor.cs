using System;

namespace AbstractFactory.MapSites
{
    public class MagicDoor : Door
    {
        public MagicDoor(Room room1, Room room2) : base(room1, room2) { }

        public override void Enter()
        {
            Console.WriteLine("Вы прошли через магическую дверь!");
        }
    }
}
