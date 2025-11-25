using System;
using Builder.MapSites;
using Builder.MazeLogic;

namespace Builder.Builders
{
    public class IceMazeBuilder : MazeBuilder
    {
        private Maze _maze = new Maze();

        public override void BuildRoom(int number)
        {
            Room room = new Room(number);
            Console.WriteLine($"Создана ледяная комната №{number}");
            _maze.AddRoom(room);
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            Room r1 = _maze.RoomNo(roomFrom);
            Room r2 = _maze.RoomNo(roomTo);
            Door door = new Door(r1, r2);
            Console.WriteLine("Создана ледяная дверь!");
        }

        public override Maze GetMaze() => _maze;
    }
}
