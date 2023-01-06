using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class QuoteGenerator
    {
        HttpClient client = new HttpClient();
        //public QuoteGenerator(HttpClient client)
        //{
        //    this.client = client;
        //}

        public string RonQuoteGenerator()
        {
            string ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            string ronSwansonResponse = client.GetStringAsync(ronSwansonURL).Result;
            string ronQuote = JArray.Parse(ronSwansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            return ronQuote;
        }
        public JToken KanyeQuoteGenerator()
        {
            string kanyeURL = "https://api.kanye.rest";
            string kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse);
            return kanyeQuote["quote"];
        }
    }
}
