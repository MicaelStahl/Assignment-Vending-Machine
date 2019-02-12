using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class ProductMenu
    {

        public void Menu(InsertMoney change, List<IProducts> products, Snacks Twix, Food Hamburger, Drinks CocaCola)
        {
            AffordProducts afford = new AffordProducts();
            int totalMoney = 0;
            bool stayAlive = true;

            foreach (int value in change.money)
            {
                totalMoney = totalMoney + value;
            }

            while (stayAlive)
            {
                Program.DisplayMessage("\nHere you'll get a list of options that are currently available. Write the first letter of the product you want:", ConsoleColor.Yellow);
                Program.DisplayMessage($"\nYou currently have {totalMoney} remaining to spend \nX if you want to add more money. \nZ if you want the remaining change back.");

                foreach (IProducts value in products)
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
                        stayAlive = false;
                        change.Insert();
                        break;
                    case 'Z':
                        stayAlive = false;
                        MoneyBack.MoneyBackCalculation(change);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
