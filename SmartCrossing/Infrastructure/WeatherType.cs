using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmartCrossing.Infrastructure
{
    public enum WeatherType
    {
        Sunny,
        CloudedFoggy,        
        LightRain,
        HeavyRain
    }

    public static class WeatherExtensions
    {
        public static string ToApiString(this WeatherType weather)
        {
            return weather switch
            {
                WeatherType.Sunny => "sunny",
                WeatherType.CloudedFoggy => "clouded_foggy",                
                WeatherType.LightRain => "light_rain",
                WeatherType.HeavyRain => "heavy_rain",
                _ => "sunny"
            };
        }
    }

    public class WeatherTypeConverter : JsonConverter<WeatherType>
    {
        public override WeatherType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();

            return value switch
            {
                "sunny" => WeatherType.Sunny,
                "clouded" => WeatherType.CloudedFoggy,                
                "light_rain" => WeatherType.LightRain,
                "heavy_rain" => WeatherType.HeavyRain,
                _ => WeatherType.Sunny
            };
        }

        public override void Write(Utf8JsonWriter writer, WeatherType value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToApiString());
        }
    }
}
