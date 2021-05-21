using BuildingDataProject.Core.Contexts;
using BuildingDataProject.Core.Entities;
using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.Repositories
{
    public class ReadingRepository : Repository<Reading, int, FrameworkContext>, IReadingRepository
    {
        public ReadingRepository(FrameworkContext dbContext) : base(dbContext)
        {

        }
    }
}
