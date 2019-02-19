using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class VendingMachine
    {
        public List<IProducts> Products;

        public VendingMachine()
        {
            Products = new List<IProducts>();
        }
        /// <summary>
        /// Creates all the wares used in the vending machine.
        /// </summary>
        public void VendingMachinery(InsertMoney change)
        {
            Drinks CocaCola = new Drinks(
                "Coca Cola", 33, 12, "Cold beverage - perfect on warm summer days", 
                "You crack open the cold Coca Cola", "sweet, bubbly taste of heaven"
                );

            Drinks Pepsi = new Drinks(
                "Pepsi", 33, 12, "Cold beverage - okay on warm summer days, inferior to Coca Cola", 
                "You crack open the cold Pepsi", "sweet, bubbly taste of inferiority over Coca Cola"
                );

            Drinks Fanta = new Drinks(
                "Fanta", 33, 12, "Cold beverage - good on warm summer days, superior to Pepsi", 
                "You crack open the cold Fanta", "sweet, bubbly taste of superior oranges");

            Food Cheeseburger = new Food(
                "Cheeseburger", 150, 29, "A filling burger - perfect if you ever feel hungry", 
                "You unwrap the badboy", "filling taste of perfection"
                );

            Food Hotdog = new Food(
                "Hotdog", 90, 25, "A spicy hotdog - perfect for lunch",
                "You pour ketchup on it", "spicyness of the chili"
                );

            Food Pizza = new Food(
                "Hawaii pizza", 300, 85, "a heavenly pizza - perfect ANYTIME of the day",
                "You prepare your tastebuds", "godlike taste of an hawaiian pizza"
                );

            Snacks Twix = new Snacks(
                "Twix", 62, 10, "A biscuity snack - perfect to eat infront of the tv or computer", 
                "You unwrap the paper" , "wonderful caramel and chocolate melting together with the biscuit"
                );
            Snacks ChocolateBall = new Snacks(
                "Chocolate ball", 65, 11, "A chocolaty snack - filled with hopes and dreams",
                "You feel your mouth watering", "Chocolaty heaven in the form of a ball"
                );

            Snacks Mars = new Snacks(
                "Mars", 65, 10, "A Marsbar - for when you feel a little special",
                "You open the marsbar", "Chocolaty wonderfulness of the Mars"
                );

            ProductMenu productMenu = new ProductMenu();

            Products.Clear();

            Products.Add(CocaCola);
            Products.Add(Pepsi);
            Products.Add(Fanta);

            Products.Add(Cheeseburger);
            Products.Add(Hotdog);
            Products.Add(Pizza);

            Products.Add(Twix);
            Products.Add(ChocolateBall);
            Products.Add(Mars);

            productMenu.Menu(change, Products, CocaCola, Pepsi, Fanta, Cheeseburger, Hotdog, Pizza, Twix, ChocolateBall, Mars);
        }
    }
}
