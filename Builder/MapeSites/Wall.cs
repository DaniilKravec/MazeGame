using System;

namespace Builder.MapSites
{
    public class Wall : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("Это стена. Пройти нельзя.");
        }
    }
}