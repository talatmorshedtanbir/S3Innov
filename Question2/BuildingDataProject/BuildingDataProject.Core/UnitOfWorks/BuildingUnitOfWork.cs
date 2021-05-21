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

        public BuildingUnitOfWork(FrameworkContext context, IBuildingRepository buildingRepository) : base(context)
        {
            BuildingRepository = buildingRepository;
        }
    }
}
