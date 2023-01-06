using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Configuration;
using System.Collections.Specialized;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main()
        {
            #region OpenWeatherAPI
            OpenWeatherMapAPI weather = new OpenWeatherMapAPI();
            var currentWeather = weather.GetCurrentWeather();
            Console.WriteLine(currentWeather);
            #endregion

            #region Ron and Kanye
            QuoteGenerator quoteGen = new QuoteGenerator();

            Console.WriteLine("It was a balmy evening one mid-January in the year 2530 when a Mr. Ron Swanson \n" +
                "and a Mr. Kanye West found themselves in the same room.  They decided to converse, \n" +
                "and this is what transpired...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Ron said to Kanye, {quoteGen.RonQuoteGenerator()} \n" +
                "\n" +
                $"To which Kanye said, \"{quoteGen.KanyeQuoteGenerator()}\"");
            Console.WriteLine();
            Console.WriteLine($"Ron then responded, {quoteGen.RonQuoteGenerator()} \n" +
                "\n" +
                $"Contemplating this, Kanye replied, \"{quoteGen.KanyeQuoteGenerator()}\"");
            Console.WriteLine();
            Console.WriteLine($"Shocked by this, Ron said, {quoteGen.RonQuoteGenerator()} \n" +
                "\n" +
                $"Kanye then announced, \"{quoteGen.KanyeQuoteGenerator()}\"");
            Console.WriteLine();
            Console.WriteLine($"Finally, Ron ended the conversation with {quoteGen.RonQuoteGenerator()} \n" +
                "\n" +
                $"Kanye, needing to get the last word in, said, \"{quoteGen.KanyeQuoteGenerator()}\"");
            Console.WriteLine();
            Console.WriteLine("The End");
            #endregion
        }
    }
}
