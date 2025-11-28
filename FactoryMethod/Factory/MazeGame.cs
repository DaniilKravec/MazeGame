using FactoryMethod.MapSites;
using FactoryMethod.MazeLogic;

namespace FactoryMethod.Factory
{
    public abstract class MazeGame
    {
        public Maze CreateMaze()
        {
            Maze maze = this.MakeMaze();
            Room r1 = this.MakeRoom(1);
            Room r2 = this.MakeRoom(2);
            Door door = this.MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            return maze;
        }

        protected abstract Maze MakeMaze();
        protected abstract Room MakeRoom(int n);
        protected abstract Door MakeDoor(Room r1, Room r2);
    }
}
