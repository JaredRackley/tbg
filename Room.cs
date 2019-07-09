
using System.Collections;

namespace tbg

{
    class Room
    {
        string name;
        string description;
        ArrayList itemsInRoom; // a list of the items in the room

        public Room(string name, string description)
        {
            this.name = name;
            this.description = description;
            itemsInRoom = new ArrayList();
        }

        public void add(Item item)
        {
            itemsInRoom.Add(item);
        }

        public void delete(Item item)
        {
            itemsInRoom.Remove(item);
        }

        public string getName()
        {
            return name;
        }

        public string getDescription()
        {
            return description;
        }
    }
}
