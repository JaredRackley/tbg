using System;
namespace tbg
{
    class Item
    {
        string name;
        string description;
        bool used;

        public Item(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        void use() // a method that uses the item 
        {
            // TODO: make a use method 
            if (!used)
            {
                Console.WriteLine("The " + name + " was used.");
                used = true;
            }
        }
    }
}
