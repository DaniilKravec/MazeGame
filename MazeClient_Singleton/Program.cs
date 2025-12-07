using System;
using SingletonPattern.Core;

class Program
{
    static void Main()
    {
        Singleton s1 = Singleton.Instance;
        Singleton s2 = Singleton.Instance;

        s1.Run();

        Console.WriteLine(s1 == s2
            ? "Обе ссылки ведут к одному Singleton!"
            : "Это ошибка, Singleton создан дважды");
    }
}