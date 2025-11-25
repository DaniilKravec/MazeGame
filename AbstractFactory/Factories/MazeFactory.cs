using AbstractFactory.MapSites;
using AbstractFactory.MazeLogic;

namespace AbstractFactory.Factories
{
    public class MazeFactory
    {
        public virtual Maze MakeMaze() => new Maze();
        public virtual Room MakeRoom(int number) => new Room(number);
        public virtual Wall MakeWall() => new Wall();
        public virtual Door MakeDoor(Room r1, Room r2) => new Door(r1, r2);
        public virtual Window MakeWindow() => new Window();
        public virtual TrapDoor MakeTrapDoor() => new TrapDoor();
    }
}

