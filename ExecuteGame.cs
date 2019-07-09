using System;

namespace tbg
{
    static class ExecuteGame
    {

        public static void getPlayerInfo(Player p)
        {
            Console.WriteLine("What's your name, soldier?");
            p.setName(Console.ReadLine()); 

            Console.WriteLine("is " + p.getName() + " your chosen name? Type y for yes");

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
        
    }
}
