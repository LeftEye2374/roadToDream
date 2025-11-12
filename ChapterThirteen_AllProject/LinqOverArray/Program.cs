using System;

Console.WriteLine("Fun With LINQ Object");
QueryOverStrings();
Console.ReadLine();

static void QueryOverStrings()
{
    string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "BioShock 2" };
    
    IEnumerable<string> subset = from g in currentVideoGames where g.Contains(" ") orderby g select g;
    foreach (string s in subset )
    {
        Console.WriteLine(s);
    }
}