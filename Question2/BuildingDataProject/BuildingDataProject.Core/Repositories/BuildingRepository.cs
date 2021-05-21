using BuildingDataProject.Core.Contexts;
using BuildingDataProject.Core.Entities;
using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.Repositories
{
    public class BuildingRepository : Repository<Building, Int16, FrameworkContext>, IBuildingRepository
    {
        public BuildingRepository(FrameworkContext dbContext) : base(dbContext)
        {

        }
    }
}
