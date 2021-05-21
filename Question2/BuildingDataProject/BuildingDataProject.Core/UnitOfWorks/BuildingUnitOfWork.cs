using BuildingDataProject.Core.Contexts;
using BuildingDataProject.Core.Repositories;
using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.UnitOfWorks
{
    public class BuildingUnitOfWork : UnitOfWork, IBuildingUnitOfWork
    {
        public IBuildingRepository BuildingRepository { get; set; }
        public IObjectRepository ObjectRepository { get; set; }
        public IDataFieldRepository DataFieldRepository { get; set; }
        public BuildingUnitOfWork(FrameworkContext context,
            IBuildingRepository buildingRepository, 
            IObjectRepository objectRepository,
            IDataFieldRepository dataFieldRepository) : base(context)
        {
            BuildingRepository = buildingRepository;
            ObjectRepository = objectRepository;
            DataFieldRepository = dataFieldRepository;
        }
    }
}
