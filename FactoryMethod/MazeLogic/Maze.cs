using System.Collections.Generic;

namespace FactoryMethod.MazeLogic
{
    public class Maze
    {
        private readonly List<object> _rooms = new List<object>();

        public void AddRoom(object room)
        {
            if (room == null)
            {
                throw new System.ArgumentNullException(nameof(room));
            }
            this._rooms.Add(room);
        }
    }
}
