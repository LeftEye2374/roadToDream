Console.WriteLine("Fun with async ->");
Console.WriteLine(DoWorkAsync());
Console.WriteLine("Completed");
Console.ReadLine();

static string DoWork()
{
    Thread.Sleep(5000);
    return "Done with work";
}

static async Task<string> DoWorkAsync()
{
    return await Task.Run(() =>
    {
        Thread.Sleep(5000);
        Console.WriteLine("Done with work");
        return "Done with work";
    });
}
