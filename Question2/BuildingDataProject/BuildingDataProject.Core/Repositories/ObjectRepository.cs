
using BuildingDataProject.Core.Contexts;
using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.Repositories
{
    public class ObjectRepository : Repository<Entities.Object, Byte, FrameworkContext>, IObjectRepository
    {
        public ObjectRepository(FrameworkContext dbContext) : base(dbContext)
        {

        }
    }
}
