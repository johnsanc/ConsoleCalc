using System;
using System.Collections.Generic;
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
            
            bool flag = true;
            while(flag)
            {
                Console.WriteLine();
                mainMenu.ShowMenuOptions();
                ConsoleKeyInfo selection = Console.ReadKey();
                switch(selection.KeyChar)
                {
                    case '1':
                        Console.WriteLine();
                        Console.Write("Please enter two numbers to add: ");
                        string input = Console.ReadLine();
                        try 
                        {

                            List<double> nums = InputParser.ParseTextToDouble(input);
                            double result = Operation.Add(nums);
                            Console.WriteLine($"Result: {result:N2}\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        flag = false;
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
