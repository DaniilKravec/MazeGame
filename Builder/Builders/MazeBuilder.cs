namespace Builder.Builders
{
    public abstract class MazeBuilder
    {
        public abstract void BuildRoom(int number);
        public abstract void BuildDoor(int room1, int room2);
    }
}