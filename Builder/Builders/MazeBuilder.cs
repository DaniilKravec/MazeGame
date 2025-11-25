using Builder.MazeLogic;
using Builder.MapSites;

namespace Builder.Builders
{
    public abstract class MazeBuilder
    {
        public abstract void BuildRoom(int number);
        public abstract void BuildDoor(int roomFrom, int roomTo);
        public abstract Maze GetMaze();
    }
}