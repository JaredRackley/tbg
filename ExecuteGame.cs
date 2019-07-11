using System;

namespace tbg
{
    static class ExecuteGame
    {

        static Room currentRoom;
        public static void getPlayerInfo(Player p)
        {
            Console.WriteLine("What's your name, soldier?");
            p.setName(Console.ReadLine()); 

            Console.WriteLine("is " + p.getName() + " your chosen name? Type yes to continue.");

            string ans = Console.ReadLine(); // yes or no answer        
            while (!ans.Equals("yes"))
            {
                Console.WriteLine("Let's try again.");
                Console.WriteLine("What's your name, soldier?");
                p.setName(Console.ReadLine()); 
                Console.WriteLine("is " + p.getName() + "your chosen name? Type y for yes");
                ans = Console.ReadLine();
            }
        }
        /* This sets the room that the player is in. */        
        public static void setCurrentRoom(Room room) 
        {
            currentRoom = room;
        }
        public static void startGame()
        {
            RoomMap.startRoom(RoomMap.westernForest);
        }
    }
}
