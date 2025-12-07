using System;
using SingletonPattern.Config;
using SingletonPattern.Interfaces;

namespace SingletonPattern.Core
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        private readonly IService _service; 

        
        private Singleton()
        {
            _service = new AppConfig();
        }

       
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }

        public void Run()
        {
            Console.WriteLine("Singleton получил доступ к сервису:");
            _service.Execute();
        }
    }
}

