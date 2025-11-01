using System;
using AbstractFactory.MapSites;
using AbstractFactory.MazeLogic;

namespace AbstractFactory.Factories
{
    public class IceMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int number)
        {
            Console.WriteLine($"Создана ледяная комната №{number}");
            return new Room(number);
        }

        public override Wall MakeWall()
        {
            Console.WriteLine("Создана ледяная стена!");
            return new Wall();
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            Console.WriteLine("Создана ледяная дверь!");
            return new Door(r1, r2);
        }
    }
}
