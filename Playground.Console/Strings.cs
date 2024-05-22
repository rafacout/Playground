namespace Playground.Console;

public static class Strings
{
    public static void Execute()
    {
        System.Console.WriteLine("Hello Strings");
        System.Console.WriteLine("");
        
        char a = 'a';
        string name = "Rafael";
        string fullName = "Rafael\nCoutinho";

        string filePath = @"c:\git\file.txt";

        //Raw string literals
        string xml = """
                        <person age=50>
                        <name>Rafael</name>
                     """;

        //Raw interpolated string literals
        var person = new { Name = "Rafael", Age = 50 };

        string json = $$"""
                        {
                            "name": "{{person.Name}}",
                            "age": {{person.Age}},
                            "calculated": "{{{person.Age + 10}}}"
                        }
                        """;

        System.Console.WriteLine(json);
        
        StringFind();
    }

    public static void StringFind()
    {
        var text = "Rafael Coutinho da Silva Sauro";
                  //012345678901234567890123456789 position
                  //123456789012345678901234567890 length
        var startText = "Coutinho";
        var endText = "Silva";
        
        var i = text.IndexOf(startText);
        var x = text.LastIndexOf("a");

        var c = text.Count();
        var l = text.Length;

        var str1 = text.Substring(i, startText.Length);

        var str2 = text.Split(startText).First().Split(endText).Last();


        var m = text.Split(startText);
    }
}