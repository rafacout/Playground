using System.Dynamic;

namespace Playground;

public static class Calculation
{
    #region Delegates
    public delegate int BinaryOperation(int x, int y);

    public static BinaryOperation Multiply = delegate(int x, int y)
    {
        return x * y;
    };
    
    public static BinaryOperation Add = (x, y) => x + y;
    #endregion
    
    #region Func
    public static Func<int, int> Square = x => x * x;
    #endregion

    #region Action
    public static Action<string, string> Print = (text, value) => Console.WriteLine($"{text}: {value}");
    #endregion

    #region Predicate
    public static Predicate<int> IsEven = x => x % 2 == 0; 
    #endregion
}

public class PersonDelegate
{
    public string Name { get; set; }
    
    public int AngerLevel;
    
    #region Events
    public event EventHandler? Shout;

    public void Poke()
    {
        AngerLevel++;

        if (AngerLevel < 3) return;
        
        Shout?.Invoke(this, EventArgs.Empty);
    }
    #endregion

    public static void Harry_Shout(object? sender, EventArgs e)
    {
        if (sender is null) return;
        
        if (sender is not PersonDelegate person) return;
        
        Console.WriteLine($"{person.Name} is angry: {person.AngerLevel}");
    }
    
    public static void Harry_Shout2(object? sender, EventArgs e)
    {
        if (sender is not PersonDelegate person) return;
        
        Console.WriteLine("Stop it!");
    }
}