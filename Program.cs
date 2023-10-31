using System;
using System.IO;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{

    public class Program
    {
        static void Main(string[] args)
        {
            //string key = File.ReadAllText("appsettings.json");

            var key = "30a13cde752af003d1d8ae023701067c";

            //string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Enter your zipcode:");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={key}";

            Console.WriteLine("");

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location.");

        }
    }
}