using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class VendingMachine
    {
        public InsertMoney change { get; set; }
        public VendingMachine Machine { get; set; }

        public void VendingMachinery()
        {
            Drinks CocaCola = new Drinks();
            Food Hamburger = new Food();
            Snacks Twix = new Snacks();

            CocaCola.Name = "(C)oca Cola";
            CocaCola.Cost = 12;
            CocaCola.Description = "Cold beverage - perfect on warm summer days";
            CocaCola.Use = "You crack open the cold Coca Cola";
            CocaCola.Taste = "sweet, bubbly taste of heaven";

            Hamburger.Name = "(H)amburger";
            Hamburger.Cost = 29;
            Hamburger.Description = "A cheesy burger - perfect if you ever feel hungry";
            Hamburger.Use = "You unwrap the badboy to take a big bite out of it";
            Hamburger.Taste = "juicy texture of perfectly grilled meat together with cheese and salad";

            Twix.Name = "(T)wix";
            Twix.Cost = 10;
            Twix.Description = "A yummy snack - biscuity on the inside with a caramel top-layer and chocolate surrounding it";
            Twix.Use = "You start unwrapping the paper to eat a chunk out of both pieces like a beast";
            Twix.Taste = "perfect flavormix of the caramel with the biscuit and the sweet chocolate";


            ProductMenu productMenu = new ProductMenu();
            
            List<IProducts> products = new List<IProducts>
            {
                CocaCola,
                Hamburger,
                Twix
            };
            productMenu.Menu(change, products, Twix, Hamburger, CocaCola);
        }
    }
}
