using FactoryMethod.MazeLogic;
using FactoryMethod.MapSites;

namespace FactoryMethod.Factory
{
    public class StandardMazeGame : MazeGame
    {
        protected override Maze MakeMaze() => new Maze();
        protected override Room MakeRoom(int n) => new Room(n);
        protected override Door MakeDoor(Room r1, Room r2) => new Door(r1, r2);
    }
}