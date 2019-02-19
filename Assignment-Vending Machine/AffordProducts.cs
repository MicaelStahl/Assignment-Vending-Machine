using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class AffordProducts
    {
        /// <summary>
        /// Checks if the user has enough money for the desired product.
        /// If yes - Sends out a message that the product has been used.
        /// If no - Sends out a message that the user couldn't afford the product
        /// </summary>
        public int AffordProduct(int totalMoney, List<IProducts> ProductsValidation, InsertMoney Change)
        {
            foreach (IProducts item in ProductsValidation)
            {
                if (totalMoney >= item.Cost)
                {
                    totalMoney -= item.Cost;
                    Change.money.Add(-item.Cost);
                    item.UseInfo();

                    return totalMoney;
                }
                Program.DisplayMessage(
               $"You couldn't afford the {item.Name}, " +
               "please either pick something else or add more money to the vending machine", ConsoleColor.Red
               );
            }
            return totalMoney;
        }
    }
}
