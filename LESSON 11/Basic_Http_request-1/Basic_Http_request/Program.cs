using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft;
using Newtonsoft.Json;

class HttpRequest
{

    static async Task Main(string[] args)
    {
        int IsContinue;
        string ApiUrl = "https://www.boredapi.com/api/activity";
        HttpClient client = new HttpClient();
        Console.WriteLine("Starting to showing the activity...");




        do
        {
            var result = await client.GetStringAsync(ApiUrl); ;

            var convertFromJson = JsonConvert.DeserializeObject<ConvertFromJson>(result);
            Console.WriteLine(convertFromJson.activity);
            Console.WriteLine("Do you want to continue? 1-YES / Other inputs-NO");
            IsContinue = int.Parse(Console.ReadLine());
        }
        while (IsContinue == 1);
    }

    public class ConvertFromJson
    {
        public string activity { get; set; }

    }
}