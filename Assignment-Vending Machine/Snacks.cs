using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class Snacks : IProducts
    {
        string name;
        string purchase;
        string use;
        int cost;
        string description;
        string taste;
        public string Taste { get { return taste; } set { taste = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Purchase { get { return purchase; } set { purchase = value; } }
        public string Use { get { return use; } set { use = value; } }
        public int Cost { get { return cost; } set { cost = value; } }
        public string Description { get { return description; } set { description = value; } }


        public void ProductsInfo()
        {
            Program.DisplayMessage($"Product: {Name} \nCost: {Cost} Kr \nDescription: {Description} \n");
        }

        public void SnacksInfo()
        {
            Program.DisplayMessage($"{Use} to taste the {Taste}", ConsoleColor.Green);
        }
    }
}
