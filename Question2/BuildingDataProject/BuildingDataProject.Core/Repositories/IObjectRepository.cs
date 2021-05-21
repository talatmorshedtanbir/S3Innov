using BuildingDataProject.Core.Contexts;
using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.Repositories
{
    public interface IObjectRepository : IRepository<Entities.Object, Byte, FrameworkContext>
    {
    }
}
