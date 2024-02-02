using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = File.ReadAllText("appsettings.json");
            var APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your city name.");
            var cityName = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=imperial&appid={APIKey}";
            Console.WriteLine();
            Console.WriteLine($"It is currently {WeatherInfo.GetTemp(apiCall)} degrees Farenheit in {cityName}.");
        }
    }
}