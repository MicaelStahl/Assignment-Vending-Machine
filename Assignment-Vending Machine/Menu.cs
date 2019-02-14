using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class Menu
    {

        public int UserMenu()
        {
            bool stayAlive = true;
            int usefulNumber = 0;
            InsertMoney change = new InsertMoney();
            VendingMachine Machine = new VendingMachine();

            do
            {
                try
                {
                    Program.DisplayMessage(
                        "Please select a option:\n" +
                        "1: To insert money to the vending machine\n" +
                        "2: To look at the vending machines content\n" +
                        "3: To get your change back and exit the machine\n" +
                        "4: To exit the vending machine without getting your change back\n"
                        );

                    int choice = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (choice)
                    {
                        case 1:
                            change.Insert();
                            break;
                        case 2:
                            Machine.VendingMachinery(change);
                            break;
                        case 3:
                            stayAlive = false;
                            MoneyBack.MoneyBackCalculation(change);
                            break;
                        case 4:
                            stayAlive = false;
                            break;

                        default:
                            throw new Exception();
                    }
                }
                catch (FormatException)
                {
                    Program.DisplayMessage("Please type a valid number!", ConsoleColor.Red);
                }
                catch (OverflowException)
                {
                    Program.DisplayMessage("Please type a value between 1-3", ConsoleColor.Red);
                }
                catch (ArgumentNullException)
                {
                    Program.DisplayMessage("Please try again", ConsoleColor.Red);
                }
                catch (Exception)
                {
                    Program.DisplayMessage("You did something wrong, please try again", ConsoleColor.Red);
                }
            } while (stayAlive);
            return usefulNumber;
        }
    }
}
