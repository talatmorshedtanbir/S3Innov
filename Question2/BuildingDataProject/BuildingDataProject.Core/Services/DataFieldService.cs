using BuildingDataProject.Core.Entities;
using BuildingDataProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BuildingDataProject.Core.Services
{
    public class DataFieldService : IDataFieldService, IDisposable
    {
        private IBuildingUnitOfWork _buildingUnitOfWork;
        public DataFieldService(IBuildingUnitOfWork buildingUnitOfWork)
        {
            _buildingUnitOfWork = buildingUnitOfWork;
        }

        public List<DataField> GetDataFields()
        {
            var dataFields = _buildingUnitOfWork.DataFieldRepository.GetAll();

            return dataFields.ToList();
        }

        public void Dispose()
        {
            _buildingUnitOfWork?.Dispose();
        }
    }
}
