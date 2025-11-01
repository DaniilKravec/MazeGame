using System;

namespace AbstractFactory.MapSites
{
    public class TrapDoor : MapSite
    {
        private readonly bool _isActive;

        public TrapDoor(bool isActive = true)
        {
            _isActive = isActive;
        }

        public override void Enter()
        {
            if (_isActive)
                Console.WriteLine("Вы провалились в люк!");
            else
                Console.WriteLine("Люк закрыт и безопасен.");
        }
    }
}
