using System;

namespace AbstractFactory.MapSites
{
    public class IceWall : Wall
    {
        public override void Enter()
        {
            Console.WriteLine("Это ледяная стена. Очень холодно!");
        }
    }
}
