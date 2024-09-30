namespace Playground;

public static class Operators
{
    public static void Execute()
    {
        var a = 3;
        var b = a++;
        
        Console.WriteLine($"a: {a}, b: {b}");
        
        Console.WriteLine(nameof(Int32));
    }
}