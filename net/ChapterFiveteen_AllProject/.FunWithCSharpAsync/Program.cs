Console.WriteLine("Fun with async ->");
MultiplyAwait();
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
        return "Done with work";
    });
}

static async Task MultiplyAwait()
{
    var task1 = Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Done with first task!");
    });
    var task2 = Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Done with second task!");
    });
    var task3 = Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Done with third task!");
    });
    await Task.WhenAll(task1, task2, task3);
}
