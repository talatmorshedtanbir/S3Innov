using BuildingDataProject.Core.Entities;
using BuildingDataProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BuildingDataProject.Core.Services
{
    public class ReadingService : IReadingService, IDisposable
    {
        private IBuildingUnitOfWork _buildingUnitOfWork;
        public ReadingService(IBuildingUnitOfWork buildingUnitOfWork)
        {
            _buildingUnitOfWork = buildingUnitOfWork;
        }

        public List<Reading> GetReadings()
        {
            var readings = _buildingUnitOfWork.ReadingRepository.GetAll();

            return readings.ToList();
        }

        public void Dispose()
        {
            _buildingUnitOfWork?.Dispose();
        }
    }
}
