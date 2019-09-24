using System;
using System.Collections.Generic;
namespace ConsoleCLI
{
    public class SimpleMenu
    {
        public List<string> menuOptions { get; }

        public SimpleMenu(params string[] options)
        {
            menuOptions = new List<string>();
            AddMenuOptions(options);
        }

        public void AddMenuOptions(params string[] items) 
        {
            menuOptions.AddRange(items);
        }

        public void ShowMenuOptions()
        {
            int counter = 1;
            foreach(var option in menuOptions)
            {
                Console.WriteLine($"{counter}. " + option);
                counter++;
            }
            Console.Write("Plese select and option: ");
        }
    }
}