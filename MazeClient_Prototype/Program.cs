using System;
using Prototype.MapSites;
using Prototype.PrototypeFactory;

class Program
{
    static void Main()
    {
        
        Room roomProto = new Room(0); 
        Wall wallProto = new Wall();
        Door doorProto = new Door(); 

        
        MazePrototypeFactory factory = new MazePrototypeFactory(roomProto, wallProto, doorProto);

       
        Room room1 = factory.MakeRoom();
        room1.Initialize(1);
        Room room2 = factory.MakeRoom();
        room2.Initialize(2);

        Door door = factory.MakeDoor(room1, room2); 

        Wall wall1 = factory.MakeWall();
        Wall wall2 = factory.MakeWall();

        Console.WriteLine("Лабиринт создан.");
    }
}

