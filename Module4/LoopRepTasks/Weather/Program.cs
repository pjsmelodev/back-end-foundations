using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] weatherForecast = {
            "sunny and warm",
            "rainy with thunderstorms",
            "cloudy and cold"
        };

        for (int i = 0; i < weatherForecast.Length; i++)
        {
            switch (weatherForecast[i])
            {
                case "sunny and warm":
                    Console.WriteLine("Today will be " + weatherForecast[i] + " so bring your sunglasses.");
                    break;
                case "rainy with thunderstorms":
                    Console.WriteLine("Today will be " + weatherForecast[i] + " so bring your unbrella.");
                    break;
                case "cloudy and cold":
                    Console.WriteLine("Today will be " + weatherForecast[i] + " so bring warm clothes.");
                    break;
                default:
                    Console.WriteLine("Error.");
                    break;
            }
        }
    }
}