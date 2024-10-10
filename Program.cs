
using Microsoft.Extensions.DependencyInjection;
using SimpleCalculator;
using SimpleCalculator.Models;

try
{
    ConsoleMenu? menu = AppServices.Provider().GetService<ConsoleMenu>();

    MenuItem? chosen = null;

    do
    {
        chosen = menu!.GetMenuChoice();

        switch (chosen!.Choice)
        {
            case 1:
                BasicMath.AddTwoNumbers();
                break;
            case 2:
                BasicMath.SubtractTwoNumbers();
                break;
            case 3:
                BasicMath.MultipyTwoNumbers();
                break;
            case 4:
                BasicMath.DiviceTwoNumbers();
                break;
            case 5:
                chosen = null;
                break;
        }

    } while (chosen != null);
}
catch (Exception ex)
{

    Console.WriteLine($"{ex.Message}\n");
}
finally
{
    ConsoleMessage.Write("Thanks for using SimpleCalculator. ",true);
    ConsoleInput.Continue();
}