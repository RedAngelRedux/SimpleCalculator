using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator;

public static class ConsoleMessage
{
    public static void Write(string message, bool clear = false) 
    {
        if (clear) Console.Clear();
        Console.Write(message ?? string.Empty); 
    }

    public static void WriteLine(string message, bool clear = false) 
    {
        if (clear) Console.Clear();
        Console.WriteLine(message ?? string.Empty); 
    }

    public static void Welcome(bool clear = true) 
    {
        if (clear) Console.Clear();
        WriteLine("Welcome to Simple Calculator"); 
    }

    public static void BlankLine() { Console.WriteLine(); }
}
