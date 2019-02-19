using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    /// <summary>
    /// The Snacks section of Products - inherits everything from the IProducts interface
    /// </summary>
    class Snacks : IProducts
    {
        string name;
        int size;
        int cost;
        string description;
        string use;
        string taste;

        public string Name { get { return name; } set { name = value; } }
        public int Size { get { return size; } set { size = value; } }
        public int Cost { get { return cost; } set { cost = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Use { get { return use; } set { use = value; } }
        public string Taste { get { return taste; } set { taste = value; } }

        public Snacks(string name, int size, int cost, string description, string use, string taste)
        {
            this.name = name;
            this.size = size;
            this.cost = cost;
            this.description = description;
            this.use = use;
            this.taste = taste;
        }

        public void ProductsInfo()
        {
            Program.DisplayMessage($"Product: {Name} \nSize: {Size} gram \nCost: {Cost} Kr \nDescription: {Description} \n");
        }

        public void UseInfo()
        {
            Program.DisplayMessage($"{Use} to taste the {Taste}", ConsoleColor.Green);
        }
    }
}
