namespace Playground;

public static class Reflections
{
    public static void Execute()
    {
        // create a person class and a object
        
        var person = new Person("Rafael", 40);
        var personType = person.GetType();
        Console.WriteLine($"Type: {personType}");
        
        var properties = personType.GetProperties();
        foreach (var property in properties)
        {
            Console.WriteLine($"{property.Name} - {property.PropertyType} : {property.GetValue(person)}");
        }
    }
    
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}