using Newtonsoft.Json.Linq;

namespace APIsAndJSON;

public class General_API_Call
{
    HttpClient client = new HttpClient();
    public void MethodTest()
    {
        string filePath = File.ReadAllText("appsettings.json");
        //Console.WriteLine(filePath);
        string privateRonUri = JObject.Parse(filePath).GetValue("TestUrl").ToString();
        //Console.WriteLine(privateRonUri);
        
        var dataFetched = client.GetStringAsync(privateRonUri).Result;
        //Console.WriteLine(dataFetched);
        
        string getNameFromAPI = JObject.Parse(dataFetched).GetValue("quote").ToString();
        //Console.WriteLine(getNameFromAPI);
        
        //string nameQuoteForRon = JArray.Parse(getNameFromAPI).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
        //Looks to be that this was unnecessary because the parse method to care of the string trimming
        // I also mistakenly put kanye api in app setting rather than rons
        // This caused me to believe it was a JArray and not a Jobject. 

        Console.WriteLine($"Kanye: {getNameFromAPI}.");
        Console.WriteLine("---------------------------------");
    }
}