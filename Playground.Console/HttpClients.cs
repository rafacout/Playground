namespace Playground.Console;

public static class HttpClients
{
    public static async void Execute()
    {
        var http = new HttpClient();

        var response = await http.GetAsync("https://www.uol.com.br");
        
        System.Console.WriteLine($"Site has {response.Content.Headers.ContentLength} bytes");
    }
}