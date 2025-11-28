using Prototype.Factory;
using Prototype.MapSites;
using System;

class Program
{
    static void Main()
    {
        MazePrototypeFactory factory =
            new MazePrototypeFactory(new Room(10), new Wall(), new Door(new Room(1), new Room(2)));

        var room1 = factory.MakeRoom();
        var room2 = factory.MakeRoom();
        var door = factory.MakeDoor(room1, room2);

        Console.WriteLine("Лабиринт создан с помощью Прототипа!");

        Console.ReadLine();
    }
}
