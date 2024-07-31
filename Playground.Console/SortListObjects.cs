namespace Playground.Console;

public static class SortListObjects
{
    public static void Execute()
    {
        var people = new List<Person>
        {
            new() {Name = "Harry", Age = 29},
            new() {Name = "Hermione", Age = 30},
            new() {Name = "Ron", Age = 31}
        };

        people.Sort();
        
        foreach (var person in people)
        {
            System.Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }    
}

public class Person : IComparable<Person?>
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public int CompareTo(Person? other)
    {
        if (other is null) return 1;
        
        return Name.CompareTo(other.Name);
    }
}