using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator.Models;

namespace SimpleCalculator;

public class ConsoleMenu
{
    private readonly IConfiguration _configuration;
    public string? MenuPrompt { get; set; } = string.Empty;
    public List<MenuItem> MenuItems { get; set; } = [];


    public ConsoleMenu(IConfiguration configuration)
    {
        _configuration = configuration;
        BuildMenu();
    }

    private void BuildMenu()
    {
        MenuPrompt = _configuration.GetSection("ConsoleAppMenu").GetSection("MenuPrompt").Value;
        MenuPrompt = (MenuPrompt == null) ? "Enter The Number of Your Menu Choice: " : MenuPrompt;

        _configuration.GetSection("ConsoleAppMenu").GetSection("MenuItems").Bind(MenuItems);
    }
    private void DisplayMenu()
    { 
        ConsoleMessage.WriteLine(MenuPrompt ?? string.Empty,true);
        Console.WriteLine();

        foreach (var item in MenuItems) Console.WriteLine($"    {item.Choice}. {item.Text}");
        Console.WriteLine();
    }

    public MenuItem? GetMenuChoice()
    {
        DisplayMenu();

        (bool result, int choice) = (false, 0);
        MenuItem? chosen = null;

        while (result == false) 
        { 
            string? choiceText = Console.ReadLine();
            (result,choice) = Validator.ParseInteger(choiceText);

            if (result == true && (chosen = MenuItems.FirstOrDefault(i => i.Choice == choice)) != null) break;

            Console.WriteLine($"{choiceText} is not a valid option.  Try again ");
        }

        return chosen;        
    }

}
