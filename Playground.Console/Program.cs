using Playground.Console.EntityFramework;

Console.WriteLine("Hello C#!");
Console.WriteLine();

//Strings.Execute();
//Numbers.Execute();
//Dynamics.Execute();
//HttpClients.Execute();
//Operators.Execute();
//Arrays.Execute();
//Exceptions.Execute();
// LogTrace.Execute();
// var constructor = new PrimaryConstructor("Rafael", 40);

// PersonDelegate person = new PersonDelegate { Name = "Harry" };
// person.Shout += PersonDelegate.Harry_Shout;
// person.Shout += PersonDelegate.Harry_Shout2;
// person.Poke();
// person.Poke();
// person.Poke();
// person.Poke();

//SortListObjects.Execute();

//RandomValues.GenerateNumbers();
//RandomValues.GenerateStrings();

using NorthwindDb db = new();

System.Console.WriteLine($"Provider: {db.Database.ProviderName}");