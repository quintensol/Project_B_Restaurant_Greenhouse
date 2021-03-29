using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Class1;
namespace Greenhouse
{
    class Program
    {
        public class Customer
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private int id;
            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            private string gender;
            public string Gender
            {
                get { return gender; }
                set { gender = value; }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(test.thisis);
            Customer bard = new Customer();
            bard.Name = "test"; bard.Gender = "Male"; bard.Id = 1;
            string jsonString = JsonSerializer.Serialize(bard);
            jsonString = JsonSerializer.Serialize(bard);
            File.WriteAllText("../../../data/test.json", jsonString);

            /*



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


            */


        }
    }
}
