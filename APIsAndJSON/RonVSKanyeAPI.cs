using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {

        HttpClient client = new HttpClient();
        public void RonAndKanyeConversation()
        {

            for (int i = 0; i <= 5; i++)
            {

                var kanyeURL = "https://api.kanye.rest/";
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
                string kanyeFormatted = $"Kanye West: {kanyeQuote}.";
                Console.WriteLine(kanyeFormatted);
                


                var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                var ronResponse = client.GetStringAsync(ronURL).Result;
                var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
                string ronFormatted = $"Ron Swanson: {ronQuote}.";
                Console.WriteLine(ronFormatted);
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
