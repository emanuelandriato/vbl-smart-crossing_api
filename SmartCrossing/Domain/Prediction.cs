using SmartCrossing.Infrastructure;

namespace SmartCrossing.Domain
{
    public class Prediction
    {
        //tempo em milissegundos que a mudança ocorrerá
        public int TimeMs { get; set; }

        //clima futuro
        public WeatherType Weather { get; set; }

        //densidade de veículos no futuro
        public float VehicleDensity { get; set; }

        //velocidade média dos veículos no futuro
        public float AverageSpeed { get; set; }        
    }
}
