using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class Food : VendingMachine, IProducts
    {
        int name;
        int purchase;
        string use;
        public int Name { get { return name; } set { name = value; } }
        public int Purchase { get { return purchase; } set { purchase = value; } }
        public string Use { get { return use; } set { use = value; } }

        public void ProductsInfo()
        {
            Program.DisplayMessage($"Product: {Name}");
        }
    }
}
