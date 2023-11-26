using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the name:");
        string name = Console.ReadLine();
        string url = $@"https://api.genderize.io/?name={name}";

        HttpClient http = new HttpClient();
        var urlPath = http.GetStringAsync(url).Result;
        var result = JsonConvert.DeserializeObject<Json>(urlPath);

        Console.WriteLine($"Name is: {result.name}  Gender is: {result.gender}  Probability is: {result.probability}");
    }
}
public class Json
{
    public string gender { get; set; }
    public string name { get; set; }
    public double probability { get; set; }
}