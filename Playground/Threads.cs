namespace Playground;

public class Threads
{
    static SemaphoreSlim _semaphore = new(3);
    public static async Task ExecuteThreadsAsync()
    {
        var threads = new List<Thread>();
        
        for (int i = 0; i < 10; i++)
        {
            var name = i.ToString();
            var thread = new Thread(() => Task1(name));
            threads.Add(thread);
        }
        
        threads.ForEach(x => x.Start());
        threads.ForEach(x => x.Join()); //wait all threads until continue
        
        Console.WriteLine("Thread complete!");
    }
   
    private static void Task1(string name)
    {
        Console.WriteLine($"Waiting thread {name}...");
        _semaphore.Wait();

        try
        {
            Console.WriteLine($" Starting Task '{name}' - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(new Random().Next(5, 10) * 1000);
            Console.WriteLine($" Completed Task '{name}' - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        }
        finally
        {
            _semaphore.Release();
        }
    }
}