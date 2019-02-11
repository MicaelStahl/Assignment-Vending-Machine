using System;

namespace Assignment_Vending_Machine
{
    class Program
    {

        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.VendingMachinery();  
        }

        public static void DisplayMessage(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
