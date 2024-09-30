using System.Diagnostics;

namespace Playground;

public class Exceptions
{
    public static void Execute()
    {
        string amount = "1";
        
        try
        {
            decimal value = Decimal.Parse(amount);

            Function1(amount);

            Console.WriteLine(value);
        }
        catch (FormatException e) when (amount.Contains("$"))
        {
            Console.WriteLine("Value cannot have $ symbol");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Invalid number");
        }
    }

    private static void Function1(string amount)
    {
        Debug.WriteLine("Debugging");
        Function2(amount);
    }

    private static void Function2(string amount)
    {
        Trace.WriteLine("Tracing");
        Function3(amount);
    }

    private static void Function3(string amount)
    {
        
    }
}