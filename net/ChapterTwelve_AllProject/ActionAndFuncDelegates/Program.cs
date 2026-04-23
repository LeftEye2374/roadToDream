using System;


Console.WriteLine("Fun With Action And Func");
Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
actionTarget("Action Message!", ConsoleColor.Yellow, 5);
Console.ReadLine();



static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
{
    ConsoleColor previus = Console.ForegroundColor;
    Console.ForegroundColor = txtColor;
    for(int i = 0; i < printCount; i++)
    {
        Console.WriteLine(msg);
    }
    Console.ForegroundColor = previus;
}

static int Add(int x, int y)
{
    return x + y;
}