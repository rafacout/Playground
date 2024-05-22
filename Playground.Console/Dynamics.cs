namespace Playground.Console;

public static class Dynamics
{
    public static void Execute()
    {
        dynamic name = "Rafael";
        System.Console.WriteLine(name);

        name = 10;
        System.Console.WriteLine(name);

        name = new { Name = "Rafael", Age = 50 };
        System.Console.WriteLine(name.Name);
        System.Console.WriteLine(name.Age);

        name = new List<int> { 1, 2, 3 };
        System.Console.WriteLine(name[0]);
    }
}