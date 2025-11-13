using System;

Console.WriteLine("Fun With LINQ Object");
QueryOverStrings();
Console.ReadLine();

static void QueryOverStrings()
{
    string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "BioShock 2" };
    
    IEnumerable<string> subset = from g in currentVideoGames where g.Contains(" ") orderby g select g;
    ReflectOverQueryResults(subset);
    foreach (string s in subset )
    {
        Console.WriteLine(s);
    }
}

static void ReflectOverQueryResults(object resultSet, string queryType ="Query Expressions")
{
    Console.WriteLine($"Info about your query using {queryType}");
    Console.WriteLine("resulSet is of type: {0}", resultSet.GetType().Name);
    Console.WriteLine("resulSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
}