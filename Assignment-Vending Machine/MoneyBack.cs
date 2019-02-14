using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class MoneyBack
    {

        public static void MoneyBackCalculation(InsertMoney change)
        {
            int[] changeBackArray = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            int totalMoney = 0;

            foreach (int value in change.money)
            {
                totalMoney = totalMoney + value;
            }

            Program.DisplayMessage($"You will receive {totalMoney} back! \nHere's the change:\n");

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
        }
    }
}
