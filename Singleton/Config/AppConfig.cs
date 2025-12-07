using System;
using SingletonPattern.Interfaces;

namespace SingletonPattern.Config
{
    public class AppConfig : IService
    {
        public void Execute()
        {
            Console.WriteLine("Работает AppConfig.");
        }
    }
}