using System.Diagnostics;

namespace Playground;

public class LogTrace
{
    public static void Execute()
    {
        string amount = "1";

        ConfigureTraceToFile();

        Trace.WriteLine("Tracing");

        Function1(amount);
    }

    private static void ConfigureTraceToFile()
    {
        string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "trace.log");

        Console.WriteLine($"Writing to {logPath}");

        var stream = File.CreateText(logPath);
        var logFile = new TextWriterTraceListener(stream);
        
        Trace.Listeners.Add(logFile);

#if DEBUG
        Trace.AutoFlush = true;
#endif
    }

    private static void Function1(string amount)
    {
        Debug.WriteLine("Debugging");
    }
}