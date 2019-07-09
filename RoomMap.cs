namespace tbg
{
    using System;
    class RoomMap
    {
        public void createRooms()
        {
            Room westernForest = new Room("The Western Forest","There is an eery vibe emanating from the trees");
        }

        // TODO another method that actually changes the rooms
        public void startRoom(Room room) // invoked after the room is changed
        {
            Console.WriteLine("You are at " + room.getName() + " " + room.getDescription() +".");
        }

        
    }
}