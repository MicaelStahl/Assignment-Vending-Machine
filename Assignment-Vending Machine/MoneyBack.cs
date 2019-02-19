using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class MoneyBack
    {
        /// <summary>
        /// This Method gives the user back the remaining change (Works exactly the same as Exercise 19)
        /// </summary>
        public static void MoneyBackCalculation(InsertMoney change)
        {
            int[] changeBackArray = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            int totalMoney = 0;

            foreach (int value in change.money)
            {
                totalMoney = totalMoney + value;
            }

            Program.DisplayMessage($"Your change is {totalMoney} \nHere's the change:\n");

            foreach (int value in changeBackArray)
            {
                int coinsBack = totalMoney / value;

                if (coinsBack >= 1)
                {
                    totalMoney -= (coinsBack * value);
                }
                Program.DisplayMessage($"{value} coins = {coinsBack}");
            }
            Program.DisplayMessage("Thank you for using my vending machine, hope it lived up to your expectations!", ConsoleColor.Green);
            Console.ReadKey(true);
        }
    }
}
