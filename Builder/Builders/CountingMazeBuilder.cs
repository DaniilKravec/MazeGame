using System;

namespace Builder.Builders
{
    public class CountingMazeBuilder : MazeBuilder
    {
        public int Rooms { get; private set; }
        public int Doors { get; private set; }

        public override void BuildRoom(int number)
        {
            Rooms++;
            Console.WriteLine($"[СЧЁТЧИК] Комнат: {Rooms}");
        }

        public override void BuildDoor(int room1, int room2)
        {
            Doors++;
            Console.WriteLine($"[СЧЁТЧИК] Дверей: {Doors}");
        }
    }
}
