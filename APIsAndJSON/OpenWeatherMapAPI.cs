using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        
        public string GetCurrentWeather()
        {
            HttpClient client = new HttpClient();
            APIkey apiKey = new APIkey();
            Console.WriteLine("Please enter a zip code you would like to see the temperature for:");
            string zipCode = Console.ReadLine();
            Console.WriteLine("Please enter a country code for the zip code you just entered: \n" +
                "(EXAMPLE: \"us\" for the United States, \"de\" for Germany, \"fr\" for France)");
            string countryCode = Console.ReadLine();
            string weatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode},{countryCode}&appid={apiKey.APIKey()}&units=imperial";
            string weatherResponse = client.GetStringAsync(weatherURL).Result;
            var currentWeather = JObject.Parse(weatherResponse);
            return $"The current temperature in that location is {currentWeather["main"]["temp"]} degrees Fahrenheit, feels like {currentWeather["main"]["feels_like"]} degrees.";
        }
    }
}
