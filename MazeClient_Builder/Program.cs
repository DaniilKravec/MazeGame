using System;
using Builder;
using Builder.Builders;
using Builder.MazeLogic;

class Program
{
    static void Main()
    {
        MazeDirector director = new MazeDirector();

        MazeBuilder builder = new IceMazeBuilder();
        Maze maze = director.ConstructSimpleMaze(builder);

        Console.WriteLine("Лабиринт успешно построен при помощи Строителя!");

        Console.ReadLine();
    }
    
}

