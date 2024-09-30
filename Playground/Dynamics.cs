using System.Dynamic;
using System.Net.Mime;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Playground;

public static class Dynamics
{
    public static void Execute()
    {
        dynamic name = "Rafael";
        Console.WriteLine(name);

        name = 10;
        Console.WriteLine(name);

        name = new { Name = "Rafael", Age = 50 };
        Console.WriteLine(name.Name);
        Console.WriteLine(name.Age);

        name = new List<int> { 1, 2, 3 };
        Console.WriteLine(name[0]);
        
        var json = "{\"Name\":\"Rafael\",\"Age\":50}";
        var person = JsonSerializer.Deserialize<dynamic>(json);
        Console.WriteLine(person.GetProperty("Name").GetString());
        
        var person2 = JsonConvert.DeserializeObject<dynamic>(json);
        Console.WriteLine(person2.Name);

        dynamic person3 = new ExpandoObject();
        person3.Name = "Rafael";
        person3.Age = 50;
        Console.WriteLine(person3.Name);
    }
}