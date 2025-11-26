using Builder.MazeLogic;
using Builder.MapSites;
using System;

namespace Builder.Builders
{
    public class IceMazeBuilder : MazeBuilder
    {
        private Maze _maze;

        public IceMazeBuilder()
        {
            _maze = new Maze();
        }

        public override void BuildRoom(int number)
        {
            if (_maze.RoomNo(number) == null)
            {
                Console.WriteLine($"Создана ледяная комната №{number}");
                Room room = new Room(number);
                _maze.AddRoom(room);
            }
        }

        public override void BuildDoor(int room1, int room2)
        {
            Room r1 = _maze.RoomNo(room1);
            Room r2 = _maze.RoomNo(room2);

            Console.WriteLine("Создана ледяная дверь!");

            Door door = new Door(r1, r2);

            r1.SetSide("East", door);
            r2.SetSide("West", door);
        }

        public Maze GetMaze()
        {
            return _maze;
        }
    }
}