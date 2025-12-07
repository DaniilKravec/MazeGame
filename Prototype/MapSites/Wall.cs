using System;

namespace Prototype.MapSites
{
    public class Wall : MapSite, IPrototype<Wall>
    {
        public Wall()
        {
        }

       
        public void Initialize()
        {
        }

        public Wall Clone()
        {
            return new Wall();
        }

        public override void Enter()
        {
            Console.WriteLine("Это клонированная стена.");
        }
    }
}


