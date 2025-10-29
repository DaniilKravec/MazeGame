using System;

namespace AbstractFactory.MapSites
{
    public class Wall : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("Это стена. Пройти нельзя.");
        }
    }
}
