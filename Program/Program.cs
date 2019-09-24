using System;
using ConsoleCLI;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMenu mainMenu = new SimpleMenu(
                "Add",
                "Quit"
            );

            mainMenu.ShowMenuOptions();
            var selection = Console.ReadKey();

            switch(selection.KeyChar)
            {
                case '1':
                    Console.WriteLine();
                    Console.WriteLine("Selected Add");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
