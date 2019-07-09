using System;
using System.Collections;

namespace tbg
{
    class Player
    {
        //  public string name { get => name; set => this.name = value; }
        string name;
        ArrayList inventory; // holds the items a player currently has
        bool alive;

        public Player()
        {
            inventory = new ArrayList();
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }


        public void printInventory()
        {
            foreach (Item item in inventory)
            {
                Console.WriteLine(name);
            }
        }
    }
}