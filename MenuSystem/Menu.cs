using System;
using System.Collections.Generic;
using System.Text;

namespace MenuSystem
{
    public class Menu
    {
        public string Title;
        private MenuItem[] menuItems;
        private int itemCount;


        public Menu(string title)
        {
            Title = title;
            menuItems = new MenuItem[12];
            itemCount = 0;
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine($"{Title}\n");
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"{i+1}. {menuItems[i].Title}");
            }
            Console.WriteLine("\n(Skriv 0 for at afslutte)");
        }

        public void AddMenuItem(string menuTitle)
        {
            menuItems[itemCount] = new MenuItem(menuTitle);
            itemCount++;
        }

        public int SelectMenuItem()
        {
            Console.Write($"\nVælg menupunkt (0-{itemCount}): ");
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input) || input < 0 || input > itemCount)
            {
                Console.WriteLine($"Du skal skrive et korrekt tal imellem 1-{itemCount} for at vælge en menu. Skriv 0 for at lukke menuen.");
            }
            if (input == 0)
                Environment.Exit(0);
            
            return input;
        }
    }
}
