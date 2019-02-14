using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class ProductMenu
    {

        //public Drinks CocaCola { get; set; }
        //public Food Hamburger { get; set; }
        //public Snacks Twix { get; set; }
        //public InsertMoney Change { get; set; }
        //public List<IProducts> Products { get; set; }
        public VendingMachine Machine { get; set; }

        public void Menu(InsertMoney Change, List<IProducts> Products, Drinks CocaCola, Food Hamburger, Snacks Twix)
        {
            AffordProducts afford = new AffordProducts();
            int totalMoney = 0;
            bool stayAlive = true;

            foreach (int value in Change.money)
            {
                totalMoney = totalMoney + value;
            }

            while (stayAlive)
            {
                Program.DisplayMessage("\nHere you'll get a list of options that are currently available. Write the first letter of the product you want:", ConsoleColor.Yellow);
                Program.DisplayMessage($"\nYou currently have {totalMoney} remaining to spend \nX if you want to add more money. \nZ if you want the remaining change back.\n");

                foreach (IProducts value in Products)
                {
                    value.ProductsInfo();
                }
                char choice = char.ToUpper(Console.ReadKey(true).KeyChar);
                
                switch(choice)
                {
                    case 'C':
                        totalMoney = afford.AffordDrinks(totalMoney, CocaCola);
                        break;
                    case 'H':
                        totalMoney = afford.AffordFood(totalMoney, Hamburger);
                        break;
                    case 'T':
                        totalMoney = afford.AffordSnacks(totalMoney, Twix);
                        break;
                    case 'X':
                        Console.Clear();
                        stayAlive = false;
                        Change.Insert();
                        break;
                    case 'Z':
                        Console.Clear();
                        stayAlive = false;
                        MoneyBack.MoneyBackCalculation(Change);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
