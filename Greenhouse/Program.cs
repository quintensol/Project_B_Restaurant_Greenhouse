using System;

namespace Greenhouse
{
    class Program
    {
        public static string FirstPage0()
        {
            Console.WriteLine("Welcome to the GreenHouse Reservation Application\n");

            Console.WriteLine("These are the avalable options:\n");
            Console.WriteLine("1. Reservation");
            Console.WriteLine("2. Menu");
            Console.WriteLine("3. Rules");
            Console.WriteLine("4. Exit");

            Console.Write("Put down your option here: ");
            string result = Console.ReadLine();

            if (result == "1") //reservation
            {
                return "1";
            }
            else if (result == "2") //menu
            {
                return "2";
            }
            else if (result == "3") //rules
            {
                return "3";
            }
            else if (result == "4") //exit
            {
                Environment.Exit(1);
                return null;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n ----This is not a valid option, try again.----\n");
                FirstPage0();
                return null;
            }
        }

        public static void MenuPage0() //voor nu void 
        {
            Console.WriteLine("Welcome to the Menu Page\n");

            Console.WriteLine("Choose the catagory you want to view\n");
            Console.WriteLine("1. Appitizer");
            Console.WriteLine("2. Main");
            Console.WriteLine("3. Dessert");
            Console.WriteLine("4. Fish");
            Console.WriteLine("5. Vegan");
            Console.WriteLine("6. Vega");
            Console.WriteLine("7. All options listed above (you can also type 'all')");

            Console.Write("What would you want to see: ");
            string result = Console.ReadLine();

            //check wat er is geinput
            if (result == "7" || result == "all")
            {
                //test cuz i dont got notin
                Console.Clear();
                Console.WriteLine("All options and stuff");
            }
        }

        static void Main(string[] args)
        {
            //Eerste page standaard open
            string FirstPage0Awnser = FirstPage0();

            //check voor ouput FirstPage0Awnser
            if (FirstPage0Awnser == "2") // menu ------ Test! Dit is nu heel lelijk 
                Console.Clear();
                MenuPage0();
        }
    }
}
