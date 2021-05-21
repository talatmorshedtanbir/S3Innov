using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.Services
{
    public interface IObjectService : IDisposable
    {
        List<Entities.Object> GetObjects();
    }
}
