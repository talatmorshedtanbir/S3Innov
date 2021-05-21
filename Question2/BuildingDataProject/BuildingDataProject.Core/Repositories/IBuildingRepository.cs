using BuildingDataProject.Core.Contexts;
using BuildingDataProject.Core.Entities;
using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.Repositories
{
    public interface IBuildingRepository : IRepository<Building, Int16, FrameworkContext>
    {
    }
}
