using BuildingDataProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingDataProject.Core.Services
{
    public class ObjectService : IObjectService, IDisposable
    {
        private IBuildingUnitOfWork _buildingUnitOfWork;
        public ObjectService(IBuildingUnitOfWork buildingUnitOfWork)
        {
            _buildingUnitOfWork = buildingUnitOfWork;
        }

        public List<Entities.Object> GetObjects()
        {
            var objects = _buildingUnitOfWork.ObjectRepository.GetAll();

            return objects.ToList();
        }

        public void Dispose()
        {
            _buildingUnitOfWork?.Dispose();
        }
    }
}
