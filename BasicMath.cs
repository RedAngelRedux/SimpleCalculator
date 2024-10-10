using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator;

public static class BasicMath
{
    public static double AddTwoNumbers()
    {
        ConsoleMessage.WriteLine("***** Basic Addition *****",true);
        ConsoleMessage.BlankLine();
        
        double x = ConsoleInput.GetNumber("Enter the first number: ");
        double y = ConsoleInput.GetNumber("Enter the second number: ");
        ConsoleMessage.BlankLine();

        ConsoleMessage.WriteLine($"{x} + {y} = {x+y}");
        ConsoleMessage.BlankLine();

        ConsoleInput.Continue("Press any key to return to the main menu...");        

        return x + y;
    }
    public static double SubtractTwoNumbers()
    {
        ConsoleMessage.WriteLine("***** Basic Subtraction *****", true);
        ConsoleMessage.BlankLine();

        double x = ConsoleInput.GetNumber("Enter the first number: ");
        double y = ConsoleInput.GetNumber("Enter the second number: ");
        ConsoleMessage.BlankLine();

        ConsoleMessage.WriteLine($"{x} - {y} = {x - y}");
        ConsoleMessage.BlankLine();

        ConsoleInput.Continue("Press any key to return to the main menu...");

        return x - y;
    }
    public static double MultipyTwoNumbers()
    {
        ConsoleMessage.WriteLine("***** Basic Multiplication *****", true);
        ConsoleMessage.BlankLine();

        double x = ConsoleInput.GetNumber("Enter the first number: ");
        double y = ConsoleInput.GetNumber("Enter the second number: ");
        ConsoleMessage.BlankLine();

        ConsoleMessage.WriteLine($"{x} * {y} = {x * y}");
        ConsoleMessage.BlankLine();

        ConsoleInput.Continue("Press any key to return to the main menu...");

        return x * y;
    }
    public static double DiviceTwoNumbers()
    {
        ConsoleMessage.WriteLine("***** Basic Division *****", true);
        ConsoleMessage.BlankLine();

        double x = ConsoleInput.GetNumber("Enter the first number: ");
        double y = ConsoleInput.GetNumber("Enter the second number: ");
        ConsoleMessage.BlankLine();

        ConsoleMessage.WriteLine($"{x} / {y} = {x / y}");
        ConsoleMessage.BlankLine();

        ConsoleInput.Continue("Press any key to return to the main menu...");

        return x / y;
    }

}
