namespace Playground.Console;

public class Exceptions
{
    public static void Execute()
    {
        string amount = "10";
        
        try
        {
            decimal value = Decimal.Parse(amount);
            System.Console.WriteLine(value);
        }
        catch (FormatException e) when (amount.Contains("$"))
        {
            System.Console.WriteLine("Value cannot have $ symbol");
        }
        catch (FormatException e)
        {
            System.Console.WriteLine("Invalid number");
        }
    }
}