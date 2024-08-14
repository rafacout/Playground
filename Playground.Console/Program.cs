using Playground.Console;
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
// person.Shout += (sender, eventArgs) => { Console.WriteLine("Anonymous method"); };
// person.Poke();
// person.Poke();
// person.Poke();
// person.Poke();

// var result1 = Calculation.Multiply(2, 3);
// var result2 = Calculation.Add(2, 3);
// var result3 = Calculation.Square(5);
// Calculation.Print("Square", result3.ToString());
// var result4 = Calculation.IsEven(5);

//SortListObjects.Execute();

//RandomValues.GenerateNumbers();
//RandomValues.GenerateStrings();

// using NorthwindDb db = new();
// System.Console.WriteLine($"Provider: {db.Database.ProviderName}");

//await Tasks.ExecuteTasksAsync();
await Threads.ExecuteThreadsAsync();