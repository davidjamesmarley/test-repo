using System.Reflection;

namespace Lib;

public static class ConsoleUtils
{
    public static string GetBaseDirectory()
    {
        return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
    }
}