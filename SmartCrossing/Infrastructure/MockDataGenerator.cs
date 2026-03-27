using SmartCrossing.Domain;
using SmartCrossing.Infrastructure.Interfaces;

namespace SmartCrossing.Infrastructure
{
    public class MockDataGenerator : IMockDataGenerator
    {
        private static readonly Random _random = new();

        public CrossingData Generate()
        {
            var predictions = GeneratePredictions();

            return new CrossingData
            {
                VehicleDensity = RandomTrafficDensity(),
                AverageSpeed = RandomVehicleSpeed(),
                Weather = RandomWeather(),
                PredictedStatus = predictions,
                TotalTime = GetTotalTime(predictions)
            };
        }

        private int RandomTrafficDensity()
        {
            return _random.Next(20, 101);
        }        

        private float RandomVehicleSpeed()
        {
            return RandomFloat(20f, 100f);
        }

        private WeatherType RandomWeather()
        {
            var values = Enum.GetValues(typeof(WeatherType));
            return (WeatherType)values.GetValue(_random.Next(values.Length));
        }

        private List<Prediction> GeneratePredictions()
        {
            var list = new List<Prediction>();

            for (int i = 1; i <= 3; i++)
            {
                list.Add(new Prediction
                {
                    TimeMs = i * 5000,
                    Weather = RandomWeather(),
                    VehicleDensity = RandomTrafficDensity(),
                    AverageSpeed = RandomVehicleSpeed(),
                });
            }

            return list;
        }

        private int GetTotalTime(List<Prediction> predictions)
        {
            if (predictions == null || predictions.Count == 0)
                return 0;

            return predictions.Max(p => p.TimeMs);
        }

        private float RandomFloat(float min, float max)
        {
            return (float)(_random.NextDouble() * (max - min) + min);
        }
    }
}
