using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    class VendingMachine
    {
        public List<int> ShopHistory;
        public List<IProducts> Products;

        public VendingMachine()
        {
            ShopHistory = new List<int>();
            Products = new List<IProducts>();
        }

        public void VendingMachinery(InsertMoney change)
        {
            Drinks CocaCola = new Drinks();
            Food Hamburger = new Food();
            Snacks Twix = new Snacks();

            CocaCola.Name = "Coca Cola";
            CocaCola.Cost = 12;
            CocaCola.Description = "Cold beverage - perfect on warm summer days";
            CocaCola.Use = "You crack open the cold Coca Cola";
            CocaCola.Taste = "sweet, bubbly taste of heaven";

            Hamburger.Name = "Hamburger";
            Hamburger.Cost = 29;
            Hamburger.Description = "A cheesy burger - perfect if you ever feel hungry";
            Hamburger.Use = "You unwrap the badboy to take a big bite out of it";
            Hamburger.Taste = "juicy texture of perfectly grilled meat together with cheese and salad";

            Twix.Name = "Twix";
            Twix.Cost = 10;
            Twix.Description = "A yummy snack - biscuity on the inside with a caramel top-layer and chocolate surrounding it";
            Twix.Use = "You start unwrapping the paper to eat a chunk out of both pieces like a beast";
            Twix.Taste = "perfect flavormix of the caramel with the biscuit and the sweet chocolate";


            ProductMenu productMenu = new ProductMenu();

            Products.Add(CocaCola);
            Products.Add(Hamburger);
            Products.Add(Twix);

            //List<IProducts> products = new List<IProducts>
            //{
            //    CocaCola,
            //    Hamburger,
            //    Twix
            //};
            productMenu.Menu(change, Products, CocaCola, Hamburger, Twix);
        }
    }
}
