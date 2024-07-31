namespace Playground.Console;

public static class RandomValues
{
    public static void GenerateNumbers()
    {
        Random r = new Random(123);
        
        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine(r.Next(1, 10));
            System.Console.WriteLine(r.NextDouble());
            System.Console.WriteLine(r.NextSingle());
        }
    }

    public static void GenerateStrings()
    {
        Random r = new Random(123);
        
        string[] beatles = r.GetItems(new []{ "John", "Paul", "George", "Ringo" }, 10); 
        
        System.Console.WriteLine("Random beatles:");
        foreach (var beatle in beatles)
        {
            System.Console.WriteLine(beatle);
        }
        
        r.Shuffle(beatles);
        System.Console.WriteLine("Shuffled beatles:");
        
        foreach (var beatle in beatles)
        {
            System.Console.WriteLine(beatle);
        }
        
    }
}