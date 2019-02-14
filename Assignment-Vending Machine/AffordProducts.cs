using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class AffordProducts
    {
        public VendingMachine Machine { get; set; }
        public Drinks CocaCola { get; set; }
        public Food Hamburger { get; set; }
        public Snacks Twix { get; set; }

        public int AffordDrinks(int totalMoney, Drinks CocaCola)
        {
            if (totalMoney >= CocaCola.Cost)
            {
                totalMoney -= CocaCola.Cost;
                CocaCola.DrinksInfo();
                return totalMoney;
            }
            Program.DisplayMessage(
                "You couldn't afford the Coca Cola, " +
                "please either pick something else or add more money to the vending machine", ConsoleColor.Red
                );
            return totalMoney;
        }

        public int AffordFood(int totalMoney, Food Hamburger)
        {
            if (totalMoney >= Hamburger.Cost)
            {
                totalMoney -= Hamburger.Cost;
                Hamburger.FoodInfo();
                return totalMoney;
            }
            Program.DisplayMessage(
                "You couldn't afford the Hamburger, " +
                "please either pick something else or add more money to the vending machine", ConsoleColor.Red
                );
            return totalMoney;
        }

        public int AffordSnacks(int totalMoney, Snacks Twix)
        {
            if (totalMoney >= Twix.Cost)
            {
                totalMoney -= Twix.Cost;
                Twix.SnacksInfo();
                return totalMoney;
            }
            Program.DisplayMessage(
                "You couldn't afford the Twix, " +
                "please either pick something else or add more money to the vending machine", ConsoleColor.Red
                );
            return totalMoney;
        }
    }
}
