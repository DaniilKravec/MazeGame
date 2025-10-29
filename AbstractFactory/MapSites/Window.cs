using System;

namespace AbstractFactory.MapSites
{
    public class Window : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("Вы смотрите в окно, пройти нельзя.");
        }
    }
}
