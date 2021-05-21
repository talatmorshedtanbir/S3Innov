using BuildingDataProject.Core.Entities;
using BuildingDataProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingDataProject.Core.Services
{
    public class BuildingService : IBuildingService, IDisposable
    {
        private IBuildingUnitOfWork _buildingUnitOfWork;
        public BuildingService(IBuildingUnitOfWork buildingUnitOfWork)
        {
            _buildingUnitOfWork = buildingUnitOfWork;
        }

        public List<Building> GetBuildings()
        {
            var buildings = _buildingUnitOfWork.BuildingRepository.GetAll();
            return buildings.ToList();
        }

        public void Dispose()
        {
            _buildingUnitOfWork?.Dispose();
        }
    }
}
