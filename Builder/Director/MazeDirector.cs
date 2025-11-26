using Builder.Builders;
using Builder.MazeLogic;

namespace Builder
{
    public class MazeDirector
    {
        public Maze ConstructSimpleMaze(MazeBuilder builder)
        {
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            if (builder is IceMazeBuilder ice)
            {
                return ice.GetMaze();
            }

            return null;
        }
    }
}
