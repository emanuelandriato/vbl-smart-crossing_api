using SmartCrossing.Application.Interfaces;
using SmartCrossing.Domain;
using SmartCrossing.Infrastructure;
using SmartCrossing.Infrastructure.Interfaces;

namespace SmartCrossing.Application
{
    public class CrossingService : ICrossingService
    {
        private readonly IMockDataGenerator _mock;

        public CrossingService(IMockDataGenerator mock)
        {
            _mock = mock;
        }

        public CrossingData GetCrossingData()
        {
            return _mock.Generate();
        }
    }
}
