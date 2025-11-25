using System;
using Builder.Builders;
using Builder.MazeLogic;

class Program
{
    static void Main()
    {
        MazeBuilder builder = new IceMazeBuilder(); 
        builder.BuildRoom(1);
        builder.BuildRoom(2);
        builder.BuildDoor(1, 2);

        Maze maze = builder.GetMaze();
        Console.WriteLine("Лабиринт успешно построен при помощи Строителя!");
    }
}

