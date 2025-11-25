using System;
using AbstractFactory.Factories;
using AbstractFactory.MapSites;
using AbstractFactory.MazeLogic;

namespace MazeClient
{
    public class Program
    {
        static void Main()
        {
            MazeFactory factory = new IceMazeFactory();
            Maze maze = CreateMaze(factory);
            Console.WriteLine("Лабиринт успешно создан!");
        }

        static Maze CreateMaze(MazeFactory factory)
        {
            Maze maze = factory.MakeMaze();

            Room room1 = factory.MakeRoom(1);
            Room room2 = factory.MakeRoom(2);
            Room room3 = factory.MakeRoom(3);

            Door door1 = factory.MakeDoor(room1, room2);
            Door door2 = factory.MakeDoor(room2, room3);

            maze.AddRoom(room1);
            maze.AddRoom(room2);
            maze.AddRoom(room3);

            room1.SetSide(0, factory.MakeWall());
            room1.SetSide(1, door1);
            room1.SetSide(2, factory.MakeWindow());
            room1.SetSide(3, factory.MakeWall());

            room2.SetSide(0, door1);
            room2.SetSide(1, door2);
            room2.SetSide(2, factory.MakeTrapDoor());
            room2.SetSide(3, factory.MakeWall());

            room3.SetSide(0, door2);
            room3.SetSide(1, factory.MakeWall());
            room3.SetSide(2, factory.MakeWindow());
            room3.SetSide(3, factory.MakeWall());

            return maze;
        }
    }
}
