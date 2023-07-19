// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//HttpClient client = new HttpClient();

// HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.

using ConsoleApp1;
using System.Net.Http.Json;
using System.Net.Security;
using System.Text.Json.Nodes;


try
{
    string url = "https://raw.githubusercontent.com/Serempre/test-json/main/list1.json";

    using var HttpClient = new HttpClient();

    List<User> result = await HttpClient.GetFromJsonAsync<List<User>>(url);

    var orderResult = result.OrderBy(x=> x.kpi.Speed).ToList();

    foreach (User user in orderResult)
    {
        Console.WriteLine($"{user.Id}");
        Console.WriteLine($"{user.Name}");
        Console.WriteLine($" KPI: Speed {user.kpi.Speed} | Level {user.kpi.Level}");
    }

}
catch (Exception)
{

    throw;
}

