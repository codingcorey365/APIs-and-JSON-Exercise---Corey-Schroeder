using System.Threading.Channels;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON;

public class QuoteGeneratorBetterPractice
{
    private HttpClient _client;

    public QuoteGeneratorBetterPractice(HttpClient client)
    {
        _client = client;
    }

    public string Kanye()
    {
        //API Url
        var kanyeURL = "https://api.kanye.rest";

        //Stores the JSON repsonse in a variable
        var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;

        //Parses through the response we received to get the value associated with
        //the NAME "quote"
        var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString(); //.Replace('[', ' ').Replace(']', ' ').Trim();
        string kanyeFormatted = $"Kanye West: {kanyeQuote}.";
        return kanyeQuote;
    }

    public string RonSwanson()
    {
        //Ron Swanson URL
        var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        var ronResponse = _client.GetStringAsync(ronURL).Result;
        var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
        string ronFormatted = $"Ron Swanson: {ronQuote}";
        return ronQuote;

        //string nameQuoteForRon = JArray.Parse(getNameFromAPI).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
    }
}