Console.WriteLine("Fun with Directory(info)");
ShowWindowDirectoryInfo();
Console.ReadLine();

static void ShowWindowDirectoryInfo()
{
    DirectoryInfo dir = new DirectoryInfo($"Window"); // path to dir
    Console.WriteLine("Directory Info: ->");
    Console.WriteLine("FullName: {0}", dir.FullName);
    Console.WriteLine("Name: {0}", dir.Name);
    Console.WriteLine("Parent: {0}", dir.Parent);
    Console.WriteLine("Creation: {0}", dir.CreationTime);
    Console.WriteLine("Attributes: {0}", dir.Attributes);
    Console.WriteLine("Root: {0}", dir.Root);
    Console.WriteLine("******************");
}