namespace Playground.Console;
using static System.Console;

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

        WriteLine(json);
        
        StringFind();
        StringFormat();
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
    
    public static void StringFormat()
    {
        var name = "Rafael";
        var age = 50;
        var salary = 1000.50;
        var percentage = 0.10;
        var digits = 123;
        var noDigits = 456;
        var decimalValue = 123.456m;
        var birthDate = new DateTime(1971, 10, 10);

        WriteLine(string.Format("Name: {0}, Age: {1}, Salary: {2:C}, Percentage: {3:P}, Digits: {4:000000}, NoDigits: {5:#####0}, Decimal: {6}, Birth Date: {7:M/d/yy}", name, age, salary, percentage, digits, noDigits, decimalValue, birthDate));
        WriteLine(string.Format("Bit: {0:B8}", 50));
    }
    
    
}