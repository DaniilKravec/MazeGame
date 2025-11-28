namespace Prototype.MapSites
{
    public class Wall : MapSite, IPrototype<Wall>
    {
        public Wall Clone()
        {
            return new Wall();
        }

        public override void Enter()
        {
            System.Console.WriteLine("Это стена.");
        }
    }
}

