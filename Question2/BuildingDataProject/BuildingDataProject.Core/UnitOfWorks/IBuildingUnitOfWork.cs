using BuildingDataProject.Core.Repositories;
using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.UnitOfWorks
{
    public interface IBuildingUnitOfWork : IUnitOfWork
    {
        IBuildingRepository BuildingRepository { get; set; }
        IObjectRepository ObjectRepository { get; set; }
        IDataFieldRepository DataFieldRepository { get; set; }
    }
}
