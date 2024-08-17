using System.Dynamic;
using System.Net.Mime;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

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
        
        var json = "{\"Name\":\"Rafael\",\"Age\":50}";
        var person = JsonSerializer.Deserialize<dynamic>(json);
        System.Console.WriteLine(person.GetProperty("Name").GetString());
        
        var person2 = JsonConvert.DeserializeObject<dynamic>(json);
        System.Console.WriteLine(person2.Name);

        dynamic person3 = new ExpandoObject();
        person3.Name = "Rafael";
        person3.Age = 50;
        System.Console.WriteLine(person3.Name);
    }
}