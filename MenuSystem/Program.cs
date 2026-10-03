using MenuSystem;

internal class Program
{
    private static void Main(string[] args)
    {

        Menu mainMenu = new Menu("Min fantastiske menu");
        string[] menuNavne = ["Gør dit", "Gør dat", "Gør noget", "42"];

        for (int i = 0; i < menuNavne.Length; i++)
        {
            mainMenu.AddMenuItem(menuNavne[i]);
        } 

        do
        {
            mainMenu.Show();

            int menuValgt = mainMenu.SelectMenuItem();
            
            Console.WriteLine($"Du har valgt: {menuNavne[menuValgt-1]}");
            Console.ReadLine();

        } while (true);
    }
}