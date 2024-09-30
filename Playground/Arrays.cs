namespace Playground;

public static class Arrays
{
    public static void Execute()
    {
        Bidimensional();
        Multidimensional();
    }

    private static void Bidimensional()
    {
        string[] names;

        names = new string[4];

        names[0] = "Rafael";
        names[1] = "Fernanda";

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
    }

    private static void Multidimensional()
    {
        string[,] grid =
        {
            {
                "Rafael Coutinho",
                "Fernanda Souza"
            },
            {
                "10.000",
                "15.000"
            }   
        };

        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                Console.WriteLine($"row {i} column {j}: {grid[i, j]}");
            }
        }
        
        
        
        
        
    }
}