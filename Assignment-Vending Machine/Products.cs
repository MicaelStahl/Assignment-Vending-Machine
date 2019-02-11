using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    interface IProducts
    {
        int Name { get; set; } // Price and info about the product itself (For example: Coca Cola - 10 KR)
        int Purchase { get; set; }
        string Use { get; set; } // For example: Drink the drink, devour the food, nibble the snacks


        void ProductsInfo();
    }
}
