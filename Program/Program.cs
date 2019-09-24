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

            SimpleMenu delimeterOptions = new SimpleMenu(
                "No customer delimeter",
                "Custom char delimeter",
                "Custom delimeter of variable length"
            );
            
            bool flag = true;
            while(flag)
            {
                Console.WriteLine();
                mainMenu.ShowMenuOptions();
                string selection = Console.ReadLine();               
                
                switch(selection)
                {
                    case "1": // Selected Add
                        Console.WriteLine();
                        Console.Write("Please enter two numbers to add: ");
                        string input = Console.ReadLine();

                        Console.WriteLine();
                        delimeterOptions.ShowMenuOptions();
                        string delimMenuOption = Console.ReadLine();
                        Console.WriteLine();
                        
                        switch(delimMenuOption)
                        {
                            case "1":  // No Delim option
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
                                Console.Write("Please enter delimeter(s) separated by a space: ");
                                
                                string delimString = Console.ReadLine();
                                string[] delimOptions = delimString.Split(' ');
                                Console.WriteLine();
                                
                                try
                                {
                                    List<double> nums = InputParser.ParseTextToDouble(input, delimOptions);
                                    
                                    double result = Operation.Add(nums);
                                    Console.WriteLine($"Result: {result:N2}\n");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            break;
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
