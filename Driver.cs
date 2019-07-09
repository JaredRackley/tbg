namespace tbg
{
    using System;
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("________           __                __         ______                       __  __        __  __             __      __                     ");
            Console.WriteLine("|        \\         |  \\              |  \\       /      \\                     |  \\|  \\      |  \\|  \\           |  \\    |  \\                    ");
            Console.WriteLine(" \\$$$$$$$$______  _| $$_     ______  | $$      |  $$$$$$\\ _______   _______   \\$$| $$____   \\$$| $$  ______  _| $$_    \\$$  ______   _______  ");
            Console.WriteLine("   | $$  /      \\|   $$ \\   |      \\ | $$      | $$__| $$|       \\ |       \\ |  \\| $$    \\ |  \\| $$ |      \\|   $$ \\  |  \\ /      \\ |       \\ ");
            Console.WriteLine("   | $$ |  $$$$$$\\\\$$$$$$    \\$$$$$$\\| $$      | $$    $$| $$$$$$$\\| $$$$$$$\\| $$| $$$$$$$\\| $$| $$  \\$$$$$$\\\\$$$$$$  | $$|  $$$$$$\\| $$$$$$$\\");
            Console.WriteLine("   | $$ | $$  | $$ | $$ __  /      $$| $$      | $$$$$$$$| $$  | $$| $$  | $$| $$| $$  | $$| $$| $$ /      $$ | $$ __ | $$| $$  | $$| $$  | $$");
            Console.WriteLine("   | $$ | $$__/ $$ | $$|  \\|  $$$$$$$| $$      | $$  | $$| $$  | $$| $$  | $$| $$| $$  | $$| $$| $$|  $$$$$$$ | $$|  \\| $$| $$__/ $$| $$  | $$");
            Console.WriteLine("   | $$  \\$$    $$  \\$$  $$ \\$$    $$| $$      | $$  | $$| $$  | $$| $$  | $$| $$| $$  | $$| $$| $$ \\$$    $$  \\$$  $$| $$ \\$$    $$| $$  | $$");
            Console.WriteLine("    \\$$   \\$$$$$$    \\$$$$   \\$$$$$$$ \\$$       \\$$   \\$$ \\$$   \\$$ \\$$   \\$$ \\$$ \\$$   \\$$ \\$$ \\$$  \\$$$$$$$   \\$$$$  \\$$  \\$$$$$$  \\$$   \\$$");
        
            System.Threading.Thread.Sleep(5000); //system sleeps for 5 seconds

            Console.WriteLine();
            Player p = new Player();
            ExecuteGame.getPlayerInfo(p);
            System.Threading.Thread.Sleep(3000); //system sleeps for 3 seconds
            Console.WriteLine();
            ExecuteGame.startGame();



        }
    }
}