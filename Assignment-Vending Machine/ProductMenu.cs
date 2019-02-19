using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class ProductMenu
    {
        public VendingMachine machine { get; set; }
        public Menu menu { get; set; }
        /// <summary>
        /// The product menu to show the 3 main alternatives (Drinks, Food, Snacks)
        /// </summary>
        public void Menu(
            InsertMoney Change, List<IProducts> Products, Drinks CocaCola, Drinks Pepsi, Drinks Fanta,
            Food Cheeseburger, Food HotDog, Food Pizza, Snacks Twix, Snacks ChocolateBalls, Snacks Mars)
        {
            AffordProducts afford = new AffordProducts();
            int totalMoney = 0;
            bool stayAlive = true;

            //foreach (int value in Change.money)
            //{
            //    totalMoney = totalMoney + value;
            //}
            while (stayAlive)
            {


                Program.DisplayMessage(
                    "There's currently 3 options per category. Please choose wisely\n" +
                    "D - Drinks\n" +
                    "F - Food\n" +
                    "S - Snacks\n" +
                    "\n" +
                    "X - Go back\n"
                    );

                char productsChoice = char.ToUpper(Console.ReadKey(true).KeyChar);

                List<IProducts> ProductsValidation = new List<IProducts>();

                switch (productsChoice)
                {
                    case 'D':
                        ProductDrinks(totalMoney, Change, afford, Products, ProductsValidation, CocaCola, Pepsi, Fanta);
                        break;
                    case 'F':
                        ProductFood(totalMoney, Change, afford, Products, ProductsValidation, Cheeseburger, HotDog, Pizza);
                        break;
                    case 'S':
                        ProductSnacks(totalMoney, Change, afford, Products, ProductsValidation, Twix, ChocolateBalls, Mars);
                        break;
                    case 'X':
                        stayAlive = false;
                        break;
                    default:
                        Program.DisplayMessage("Please type one of the given values. (D, F, S, X)", ConsoleColor.Red);
                        break;
                }
                Console.Clear();
            }
        }
        /// <summary>
        /// The product menu for drinks
        /// </summary>
        public void ProductDrinks(int totalMoney, InsertMoney Change, AffordProducts afford, List<IProducts> Products, List<IProducts> ProductsValidation,
            Drinks CocaCola, Drinks Pepsi, Drinks Fanta)
        {
            Console.Clear();

            Program.DisplayMessage("\nIt would seem you picked drinks! You must be thirsty!", ConsoleColor.Green);
            bool stayAlive = true;

            foreach (int value in Change.money)
            {
                totalMoney = totalMoney + value;
            }

            while (stayAlive)
            {

                Program.DisplayMessage("\nHere's youll get a list of drinks that's currently available. Please pick one");
                Program.DisplayMessage("\n(You select a drink by writing the first letter of the product you want)\n", ConsoleColor.Yellow);

                Program.DisplayMessage(
                    $"You currently have {totalMoney} remaining to spend \nX - Go back. " +
                    $"\nZ - remaining change back.\n"
                    );

                foreach (IProducts item in Products)
                {
                    if (item is Drinks)
                    {
                        item.ProductsInfo();
                    }
                }
                char choiceDrinks = char.ToUpper(Console.ReadKey(true).KeyChar);


                switch (choiceDrinks)
                {
                    case 'C':
                        ProductsValidation.Add(CocaCola);
                        totalMoney = afford.AffordProduct(totalMoney, ProductsValidation, Change);
                        break;
                    case 'P':
                        ProductsValidation.Add(Pepsi);
                        totalMoney = afford.AffordProduct(totalMoney, ProductsValidation, Change);
                        break;
                    case 'F':
                        ProductsValidation.Add(Fanta);
                        totalMoney = afford.AffordProduct(totalMoney, ProductsValidation, Change);
                        break;
                    case 'X':
                        stayAlive = false;
                        break;
                    case 'Z':
                        Console.Clear();
                        MoneyBack.MoneyBackCalculation(Change);
                        stayAlive = false;
                        break;
                    default:
                        Program.DisplayMessage("Invalid keypress, please try again", ConsoleColor.Red);
                        break;
                }
                ProductsValidation.Clear();

                if (stayAlive == true) { Console.ReadKey(true); }
                Console.Clear();
            }
        }

        /// <summary>
        /// The product menu for food
        /// </summary>
        private void ProductFood(int totalMoney, InsertMoney Change, AffordProducts afford, List<IProducts> Products, List<IProducts> ProductsValidation, 
            Food Cheeseburger, Food Hotdog, Food Pizza)
        {
            Console.Clear();

            Program.DisplayMessage("\nIt would seem you picked food! You must be hungry!", ConsoleColor.Green);
            bool stayAlive = true;

            foreach (int value in Change.money)
            {
                totalMoney = totalMoney + value;
            }

            while (stayAlive)
            {


                Program.DisplayMessage("\nHere's youll get a list of drinks that's currently available. Please pick one");
                Program.DisplayMessage("\n(You select a drink by writing the first letter of the product you want)\n", ConsoleColor.Yellow);

                Program.DisplayMessage(
                    $"You currently have {totalMoney} remaining to spend \nX - Go back. " +
                    $"\nZ - remaining change back.\n"
                    );

                foreach (IProducts item in Products)
                {
                    if (item is Food)
                    {
                        item.ProductsInfo();
                    }
                }

                char choiceDrinks = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (choiceDrinks)
                {
                    case 'C':
                        ProductsValidation.Add(Cheeseburger);
                        totalMoney = afford.AffordProduct(totalMoney, ProductsValidation, Change);
                        break;
                    case 'H':
                        ProductsValidation.Add(Hotdog);
                        totalMoney = afford.AffordProduct(totalMoney, ProductsValidation, Change);
                        break;
                    case 'P':
                        ProductsValidation.Add(Pizza);
                        totalMoney = afford.AffordProduct(totalMoney, ProductsValidation, Change);
                        break;
                    case 'X':
                        stayAlive = false;
                        break;
                    case 'Z':
                        Console.Clear();
                        MoneyBack.MoneyBackCalculation(Change);
                        stayAlive = false;
                        break;
                    default:
                        Program.DisplayMessage("Invalid keypress, please try again", ConsoleColor.Red);
                        break;
                }
                ProductsValidation.Clear();

                if (stayAlive == true) { Console.ReadKey(true); }

                Console.Clear();
            }
        }
        /// <summary>
        /// The product menu for snacks
        /// </summary>
        private void ProductSnacks(int totalMoney, InsertMoney Change, AffordProducts afford, List<IProducts> Products, List<IProducts> ProductsValidation, 
            Snacks Twix, Snacks ChocolateBalls, Snacks Mars)
        {
            Console.Clear();

            Program.DisplayMessage("\nIt would seem you picked snacks! You must want a good snacky snack!", ConsoleColor.Green);
            bool stayAlive = true;

            foreach (int value in Change.money)
            {
                totalMoney = totalMoney + value;
            }

            while (stayAlive)
            {

                Program.DisplayMessage("\nHere's youll get a list of drinks that's currently available. Please pick one");
                Program.DisplayMessage("\n(You select a drink by writing the first letter of the product you want)\n", ConsoleColor.Yellow);

                Program.DisplayMessage(
                    $"You currently have {totalMoney} remaining to spend \nX - Go back. " +
                    $"\nZ - remaining change back.\n"
                    );

                foreach (IProducts item in Products)
                {
                    if (item is Snacks)
                    {
                        item.ProductsInfo();
                    }
                }
                char choiceDrinks = char.ToUpper(Console.ReadKey(true).KeyChar);


                switch (choiceDrinks)
                {
                    case 'T':
                        ProductsValidation.Add(Twix);
                        totalMoney = afford.AffordProduct(totalMoney, ProductsValidation, Change);
                        break;
                    case 'C':
                        ProductsValidation.Add(ChocolateBalls);
                        totalMoney = afford.AffordProduct(totalMoney, ProductsValidation, Change);
                        break;
                    case 'M':
                        ProductsValidation.Add(Mars);
                        totalMoney = afford.AffordProduct(totalMoney, ProductsValidation, Change);
                        break;
                    case 'X':
                        stayAlive = false;
                        break;
                    case 'Z':
                        Console.Clear();
                        MoneyBack.MoneyBackCalculation(Change);
                        stayAlive = false;
                        break;
                    default:
                        Program.DisplayMessage("Invalid keypress, please try again", ConsoleColor.Red);
                        break;
                }
                ProductsValidation.Clear();
                if (stayAlive == true) { Console.ReadKey(true); }
                Console.Clear();
            }
        }
    }
}
