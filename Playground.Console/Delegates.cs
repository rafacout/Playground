namespace Playground.Console;

public class PersonDelegate
{
    public string Name { get; set; }
    
    #region Events
    public event EventHandler? Shout;

    public int AngerLevel;

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
        
        System.Console.WriteLine($"{person.Name} is angry: {person.AngerLevel}");
    }
    
    public static void Harry_Shout2(object? sender, EventArgs e)
    {
        if (sender is not PersonDelegate person) return;
        
        System.Console.WriteLine("Stop it!");
    }
}

