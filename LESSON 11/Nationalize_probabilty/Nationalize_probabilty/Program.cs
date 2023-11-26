using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the name:");
        string name = Console.ReadLine();
        string url = @$"https://api.nationalize.io/?name={name}";

        HttpClient client = new HttpClient();
        var result = client.GetStringAsync(url).Result;
        
        var info = JsonConvert.DeserializeObject<JsonResult>(result);
        Console.WriteLine($"Name is: {info.name}");

        foreach ( var item in info.country)
        {
            Console.WriteLine($"Country is: {item.country_id}  Probability is: {item.probability}");    
        }

        Console.WriteLine();
    }
}

public class Country
{
    public double probability { get; set; }
    public string country_id { get; set; }
}

public class JsonResult
{
    public string name { get; set; }
    public Country[] country { get; set; }
}