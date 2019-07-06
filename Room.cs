
using System.Collections;

namespace tbg

{
    class Room
    {
        string name;
        string description; 
        ArrayList itemsInRoom; // a list of the items in the room

        public Room(string name,string description, ArrayList itemsInRoom)
        {
            this.name = name;
            this.description =description;
            this.itemsInRoom.Add(itemsInRoom.Clone());
        }
    }
}
