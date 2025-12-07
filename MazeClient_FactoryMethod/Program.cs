using System;
using FactoryMethod.Factory;
class Program
{
    static void Main()
    {
        MazeGame game = new StandardMazeGame();
        var maze = game.CreateMaze();
        System.Console.WriteLine("Лабиринт создан (Фабричный метод).");

        Console.ReadLine();
    }
}
