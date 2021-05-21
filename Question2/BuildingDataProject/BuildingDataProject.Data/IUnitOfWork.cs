using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
