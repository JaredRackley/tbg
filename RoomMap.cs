namespace tbg
{
    using System;
    static class RoomMap
    {
        public static Room westernForest = new Room("The Western Forest","There is an eery vibe emanating from the trees");
        public static void createRooms()
        {
            
            
        }

        // TODO another method that actually changes the rooms
        public static void startRoom(Room room) // invoked after the room is changed
        {
            Console.WriteLine("You are at " + room.getName() + " " + room.getDescription() +".");
        }


    }
}