using System;

namespace AbstractFactory.MapSites
{
    public class EnchantedRoom : Room
    {
        public EnchantedRoom(int number) : base(number) { }

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в волшебную комнату №{Number}");
        }
    }
}

