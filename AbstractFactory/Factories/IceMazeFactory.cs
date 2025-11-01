using System;
using AbstractFactory.MapSites;

namespace AbstractFactory.Factories
{
    public class IceMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int number)
        {
            Console.WriteLine($"Создана ледяная комната №{number}");
            return new IceRoom(number);
        }

        public override Wall MakeWall()
        {
            Console.WriteLine("Создана ледяная стена!");
            return new IceWall();
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            Console.WriteLine("Создана ледяная дверь!");
            return new IceDoor(r1, r2);
        }
    }
}
