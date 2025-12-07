using System;
using SingletonPattern.Interfaces;

namespace SingletonPattern.Logging
{
    public class Logger : IService
    {
        public void Execute()
        {
            Log("Выполнена операция через Logger.");
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss}: {message}");
        }
    }
}