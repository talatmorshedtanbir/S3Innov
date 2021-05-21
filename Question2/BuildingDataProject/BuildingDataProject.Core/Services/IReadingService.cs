using BuildingDataProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.Services
{
    public interface IReadingService : IDisposable
    {
        List<Reading> GetReadings();
    }
}
