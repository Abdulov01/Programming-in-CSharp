
using Newtonsoft.Json;
using System;
using System.Net;
using System.Text.Json.Nodes;



class Program
{

    static void Main(string[] args)
    {
        int i;
        
        string myUrl = @"https://dog.ceo/api/breeds/image/random";
        Console.WriteLine("Getting process...");

        for (i = 0; i < 100; i++) 
        {
            string adress = @"C:\Users\Abdulov\Downloads\Dogs\" + Guid.NewGuid();
            HttpClient http = new HttpClient();
            var result = http.GetStringAsync(myUrl).Result;
            Url url = JsonConvert.DeserializeObject<Url>(result);

            WebClient web = new WebClient();

            web.DownloadFile(url.message, adress + ".jpg");    
        }

        Console.WriteLine("The process succesfully finished");
    }
}
    public class Url
    {
        public string message { get; set; }
        public string status { get; set; }
    }

