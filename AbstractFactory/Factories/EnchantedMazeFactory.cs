using System;
using AbstractFactory.MapSites;

namespace AbstractFactory.Factories
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int number)
        {
            Console.WriteLine($"Создана волшебная комната №{number}");
            return new EnchantedRoom(number);
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            Console.WriteLine("Создана магическая дверь между комнатами!");
            return new MagicDoor(r1, r2);
        }
    }
}
