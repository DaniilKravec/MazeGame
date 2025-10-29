using System;
using AbstractFactory.MapSites;
using AbstractFactory.MazeLogic;

namespace AbstractFactory.Factories
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int number)
        {
            Console.WriteLine($"Создана волшебная комната №{number}");
            return new Room(number);
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            Console.WriteLine("Создана магическая дверь между комнатами!");
            return new Door(r1, r2);
        }
    }
}
