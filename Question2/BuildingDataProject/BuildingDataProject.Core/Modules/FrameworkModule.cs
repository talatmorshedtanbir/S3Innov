using Autofac;
using BuildingDataProject.Core.Contexts;
using BuildingDataProject.Core.Repositories;
using BuildingDataProject.Core.Services;
using BuildingDataProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.Modules
{
    public class FrameworkModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FrameworkModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FrameworkContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<BuildingRepository>().As<IBuildingRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BuildingService>().As<IBuildingService>()
               .InstancePerLifetimeScope();

            builder.RegisterType<BuildingUnitOfWork>().As<IBuildingUnitOfWork>()
              .InstancePerLifetimeScope();

            builder.RegisterType<ObjectService>().As<IObjectService>()
             .InstancePerLifetimeScope();

            builder.RegisterType<ObjectRepository>().As<IObjectRepository>()
             .InstancePerLifetimeScope();

            builder.RegisterType<DataFieldService>().As<IDataFieldService>()
             .InstancePerLifetimeScope();

            builder.RegisterType<DataFieldRepository>().As<IDataFieldRepository>()
             .InstancePerLifetimeScope();

            builder.RegisterType<ReadingService>().As<IReadingService>()
            .InstancePerLifetimeScope();

            builder.RegisterType<ReadingRepository>().As<IReadingRepository>()
             .InstancePerLifetimeScope();


            base.Load(builder);
        }
    }
}
