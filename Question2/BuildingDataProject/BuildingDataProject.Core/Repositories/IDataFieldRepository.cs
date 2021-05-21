using BuildingDataProject.Core.Contexts;
using BuildingDataProject.Core.Entities;
using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.Repositories
{
    public interface IDataFieldRepository : IRepository<DataField, Byte, FrameworkContext>
    {
    }
}
