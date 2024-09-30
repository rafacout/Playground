namespace Playground;

public static class RandomValues
{
    public static void GenerateNumbers()
    {
        Random r = new Random(123);
        
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(r.Next(1, 10));
            Console.WriteLine(r.NextDouble());
            Console.WriteLine(r.NextSingle());
        }
    }

    public static void GenerateStrings()
    {
        Random r = new Random(123);
        
        string[] beatles = r.GetItems(new []{ "John", "Paul", "George", "Ringo" }, 10); 
        
        Console.WriteLine("Random beatles:");
        foreach (var beatle in beatles)
        {
            Console.WriteLine(beatle);
        }
        
        r.Shuffle(beatles);
        Console.WriteLine("Shuffled beatles:");
        
        foreach (var beatle in beatles)
        {
            Console.WriteLine(beatle);
        }
        
    }
}