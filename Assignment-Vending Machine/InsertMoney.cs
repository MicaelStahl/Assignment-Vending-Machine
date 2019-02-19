using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class InsertMoney
    {
        public List<int> money;
        public InsertMoney Change { get; set; }

        public InsertMoney()
        {
            money = new List<int>();
        }
        /// <summary>
        /// This Method allows the user to put money in the vending machine itself.
        /// </summary>
        public void Insert()
        {
            bool stayAlive = true;
            int coinsValue = 0;

            foreach (int value in money)
            {
                coinsValue = coinsValue + value;
            }

            while (stayAlive)
            {
                try
                {
                    Program.DisplayMessage($"You can currently use {coinsValue} coins in this vending machine");

                    Program.DisplayMessage("\nPlease insert a coin/paper value of your choosing (1, 5, 10, 20, 50, 100, 500, 1000) \nOr -1 to exit. \n");
                    int coinInsert = int.Parse(Console.ReadLine());

                    switch (coinInsert)
                    {
                        case 1:
                            coinsValue += 1;
                            money.Add(1);
                            break;
                        case 5:
                            coinsValue += 5;
                            money.Add(5);
                            break;
                        case 10:
                            coinsValue += 10;
                            money.Add(10);
                            break;
                        case 20:
                            coinsValue += 20;
                            money.Add(20);
                            break;
                        case 50:
                            coinsValue += 50;
                            money.Add(50);
                            break;
                        case 100:
                            coinsValue += 100;
                            money.Add(100);
                            break;
                        case 500:
                            coinsValue += 500;
                            money.Add(500);
                            break;
                        case 1000:
                            coinsValue += 1000;
                            money.Add(1000);
                            break;
                        case -1:
                            stayAlive = false;
                            break;
                        default:
                            throw new Exception();
                    }

                    if (stayAlive == true)
                    {
                        Program.DisplayMessage($"You successfully added {coinInsert} to the moneypool!", ConsoleColor.Green);
                    }
                }
                catch (FormatException)
                {
                    Program.DisplayMessage("Please try again by writing a numberic value this time.", ConsoleColor.Red);
                }
                catch (OverflowException)
                {
                    Program.DisplayMessage("Please pick one of the following values: 1, 5, 10, 20, 50, 100, 500, 1000.", ConsoleColor.Red);
                }
                catch (ArgumentNullException)
                {
                    Program.DisplayMessage("Sorry, Null isn't a valid input. Please try again", ConsoleColor.Red);
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}