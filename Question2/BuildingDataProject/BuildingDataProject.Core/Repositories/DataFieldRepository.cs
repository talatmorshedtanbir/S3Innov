using BuildingDataProject.Core.Contexts;
using BuildingDataProject.Core.Entities;
using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.Repositories
{
    public class DataFieldRepository : Repository<DataField, Byte, FrameworkContext>, IDataFieldRepository
    {
        public DataFieldRepository(FrameworkContext dbContext) : base(dbContext)
        {

        }
    }
}
