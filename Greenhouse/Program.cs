using System;

namespace Greenhouse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            do
            {
                Console.WriteLine("Press 1 for test");
                Console.WriteLine("Press 2 for test2");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Food1");
                        Console.WriteLine("Food2");
                        Console.WriteLine("Do you wanna close the program?\nType yes to close, everything else will go back to the menu");
                        string back = Console.ReadLine();
                        quit = back == "yes" ? true : false;
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Food4");
                        Console.WriteLine("Food5");
                        Console.WriteLine("Food6");
                        break;
                }

            } while (!quit);



        }
    }
}
