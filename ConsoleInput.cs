using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator;

public static class ConsoleInput
{
    public static ConsoleKeyInfo GetAnyKey()
    {
        return Console.ReadKey();
    }

    public static void Continue(string prompt = "Press any key to continue...")
    {
        ConsoleMessage.Write(prompt);
        GetAnyKey();
    }
    public static double GetNumber(string prompt = "Enter a valid number: ")
    {
        (bool result, double number) = (false, 0);

        while (result == false) 
        {
            ConsoleMessage.Write(prompt);
            string? userInput = Console.ReadLine();
            (result, number) = Validator.ParseDouble(userInput);
            if(result == false)
            {
                ConsoleMessage.WriteLine($"{userInput} is not a valid number.\n");
            }
        }
        return number;
    }
}
