using System.Reflection;
using System.Runtime.CompilerServices;

namespace App;

internal static class Program
{
    internal const string HEADER_TEXT = "\nTest Console Application version 1.0.0.0\n\n";
    internal const string USAGE_TEXT = "App.exe [--version | --name <name>]\n";

    internal static int Main(string[] args)
    {
        Console.Write(HEADER_TEXT);
        Console.Write($"Base path: {Lib.ConsoleUtils.GetBaseDirectory()}\n");

        if (args.Length == 1 && args[0] == "--version")
        {
            Console.Write("Version 1.0.0.0\n");
            return 0;
        }

        if (args.Length == 2 && args[0] == "--name" && args[1].Length > 0)
        {
            Console.Write($"Hello, {args[1].Trim()}!\n");
            return 0;
        }

        Console.Write(USAGE_TEXT);
        return 1;
    }
}