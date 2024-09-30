namespace Playground;

public static class Switchs
{
    public static void Execute()
    {
        var animals = new Animal[]
        {
            new Dog() { name = "Dog", legs = 4 },
            new Animal() { name = "Cat", legs = 4 },
        };

        foreach (var a in animals)
        {
            //modern
            switch (a)
            {
                case Dog d when d.legs == 4:
                    Console.WriteLine($"Dog with 4 legs");
                    break;
            }

            //default
            switch (a)
            {
                case Dog d:
                    Console.WriteLine($"Dog with {d.legs} legs");
                    break;
                case Animal n:
                    Console.WriteLine($"Animal with {n.legs} legs");
                    break;
            }
        }
    }
}

public class Animal
{
    public string name { get; set; }
    public int legs { get; set; }
}

public class Dog : Animal
{
    public Dog()
    {
        name = "Dog";
        legs = 4;
    }
}