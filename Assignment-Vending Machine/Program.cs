using System;

namespace Assignment_Vending_Machine
{
    class Program
    {

        static void Main(string[] args)
        {
            DisplayMessage("\t" + @" __      __               _  _                 __  __               _      _              ");
            DisplayMessage("\t" + @" \ \    / /              | |(_)               |  \/  |             | |    (_)             ");
            DisplayMessage("\t" + @"  \ \  / /___  _ __    __| | _  _ __    __ _  | \  / |  __ _   ___ | |__   _  _ __    ___ ");
            DisplayMessage("\t" + @"   \ \/ // _ \| '_ \  / _` || || '_ \  / _` | | |\/| | / _` | / __|| '_ \ | || '_ \  / _ \");
            DisplayMessage("\t" + @"    \  /|  __/| | | || (_| || || | | || (_| | | |  | || (_| || (__ | | | || || | | ||  __/");
            DisplayMessage("\t" + @"     \/  \___||_| |_| \__,_||_||_| |_| \__, | |_|  |_| \__,_| \___||_| |_||_||_| |_| \___|");
            DisplayMessage("\t" + @"                                        __/ |                                             ");
            DisplayMessage("\t" + @"                                       |___/  _                                           ");
            DisplayMessage("\t" + @"                                          | || |                                          ");
            DisplayMessage("\t" + @"                                          | || |_                                         ");
            DisplayMessage("\t" + @"                                          |__   _|                                        ");
            DisplayMessage("\t" + @"                                             | |                                          ");
            DisplayMessage("\t" + @"                                             |_|                                          ");

            Console.ReadKey(true);
            Console.Clear();

            Menu menu = new Menu();
            menu.UserMenu();
        }

        public static void DisplayMessage(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
