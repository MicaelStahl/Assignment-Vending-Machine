using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Vending_Machine
{
    /// <summary>
    /// A interface class that gives out "blueprints" to the products to follow.
    /// </summary>
    interface IProducts
    {
        string Name { get; set; }
        int Size { get; set; }
        int Cost { get; set; }
        string Use { get; set; } 
        string Description { get; set; }
        string Taste { get; set; }

        void ProductsInfo();

        void UseInfo();
        
    }
}