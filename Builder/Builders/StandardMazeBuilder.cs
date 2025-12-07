using Builder.MazeLogic;
using Builder.MapSites;
using System;

namespace Builder.Builders
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze _currentMaze = new Maze();

        public override void BuildRoom(int number)
        {
            if (_currentMaze.RoomNo(number) != null)
                return;

            Room room = new Room(number);
            room.SetSide("North", new Wall());
            room.SetSide("South", new Wall());
            room.SetSide("East", new Wall());
            room.SetSide("West", new Wall());
            _currentMaze.AddRoom(room);
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            Room r1 = _currentMaze.RoomNo(roomFrom);
            Room r2 = _currentMaze.RoomNo(roomTo);

            if (r1 == null || r2 == null)
            {
                throw new ArgumentException("Обе комнаты должны существовать.");
            }

            Door door = new Door(r1, r2);
            r1.SetSide("East", door);
            r2.SetSide("West", door);
        }

        public Maze GetMaze() => _currentMaze;
    }
}