using Newtonsoft.Json.Linq;

namespace APIsAndJSON;

public class General_API_Call
{
    HttpClient client = new HttpClient();
    public void MethodTest()
    {
        string filePath = File.ReadAllText("appsettings.json");
        string testUrl = JObject.Parse(filePath).GetValue("TestUrl").ToString();
        var dataFetched = client.GetStringAsync(testUrl).Result;
        
        Console.WriteLine(dataFetched);
    }
}