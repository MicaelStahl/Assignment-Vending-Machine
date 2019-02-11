using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class VendingMachine
    {
        public InsertMoney change { get; set; }

        public VendingMachine() { }

        public void VendingMachinery()
        {
            change = new InsertMoney();
            Drinks drinks = new Drinks();
            Food food = new Food();
            Snacks snacks = new Snacks();
            
            change.Insert();           

        }
    }
}
