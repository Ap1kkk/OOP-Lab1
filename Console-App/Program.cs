using Console_App;
using System.Configuration;

internal class Program
{
    private static readonly string _username = ConfigurationManager.AppSettings.Get("Username");

    private static void Main(string[] args)
    {
        PrintWelcomeMessage();

        WaitForCloseApp();

        PrintFarewellMessage();
    }

    private static void WaitForCloseApp()
    {
        Console.WriteLine(MainResources.WaitingForCloseString);
        Console.ReadLine();
    }

    private static void PrintWelcomeMessage()
    {
        Console.WriteLine(MainResources.WelcomeStringPlaceholer + _username);
    }
    private static void PrintFarewellMessage()
    {
        Console.WriteLine(MainResources.FarewellStringPlaceholder + _username);
    }
}