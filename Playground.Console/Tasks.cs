namespace Playground.Console;

public class Tasks
{
    public static async Task ExecuteTasksAsync()
    {
        await ReadDatabaseAsync("A", 2000);
        await ReadDatabaseAsync("B", 1000);
        await ReadDatabaseAsync("C", 3000);
        await ReadDatabaseAsync("D", 500);
        
        Task<string> task = Task.Run(() => ReadDatabaseAsync("Task", 1000));
        string result = await task;
        System.Console.WriteLine($"Result: {result}");
        
        System.Console.WriteLine("Tasks complete!");
    }

    private static async Task<string> ReadDatabaseAsync(string name, int miliseconds)
    {
        await Task.Delay(miliseconds);
        System.Console.WriteLine($"Task Completed: {name} - {miliseconds} miliseconds");
        return "Done";
    }
}