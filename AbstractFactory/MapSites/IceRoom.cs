using System;

namespace AbstractFactory.MapSites
{
    public class IceRoom : Room
    {
        public IceRoom(int number) : base(number) { }

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в ледяную комнату №{Number}");
        }
    }
}
