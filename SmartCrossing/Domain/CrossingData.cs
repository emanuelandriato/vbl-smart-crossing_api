using SmartCrossing.Infrastructure;
using System.Net;

namespace SmartCrossing.Domain
{

    //Como está a rua AGORA e o que vai acontecer nos próximos segundos ???
    public class CrossingData
    {
        //quão cheia está a via em % de densidade? para definir a frequência de spawn de veículos
        public int VehicleDensity { get; set; }

        //velocidade média dos veículos(km/h)
        public float AverageSpeed { get; set; }

        //estado climático atual, afeta na velocidade de movimentação do usuário
        public WeatherType Weather { get; set; }

        //quanto tempo o jogador tem para realizar a travessia
        public int TotalTime { get; set; }

        //como a rua vai mudar ao longo do tempo
        public List<Prediction> PredictedStatus { get; set; }
    }
}
