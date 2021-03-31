using System;
namespace Rules{
	
	public class ShowPage
	{
        public void show()
        {
			// Lets program run until user types home
			bool running = true;
			do
			{
				Console.Clear();
				Console.WriteLine("1. Dont dbwad wadiadonsectetur adipiscing elit. Sed viverra sem in varius commodo. Ut he");
				Console.WriteLine("2. Dont dbwad wadiadonsectetur adipiscing elit. Sed viverra sem in varius commodo. Ut he");
				Console.WriteLine("3. Dont dbwad wadiadonsectetur adipiscing elit. Sed viverra sem in varius commodo. Ut he");
				Console.WriteLine("type home to return home");

				if (Console.ReadLine() == "home")
				{
					// If home close this loop 
					running = false;
					Console.Clear();

				}
			} while (running);
		}







	}
}

