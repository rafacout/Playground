namespace Playground.Console;

public static class Operators
{
    public static void Execute()
    {
        var a = 3;
        var b = a++;
        
        System.Console.WriteLine($"a: {a}, b: {b}");
        
        System.Console.WriteLine(nameof(Int32));
    }
}