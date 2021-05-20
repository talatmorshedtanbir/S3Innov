using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BuildingDataProject
{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public WebModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CampaignModel>();
            builder.RegisterType<GroupModel>();
            builder.RegisterType<SmtpModel>();
            builder.RegisterType<ContactModel>();
            builder.RegisterType<CustomerModel>();
            builder.RegisterType<ReportModel>();
            builder.RegisterType<MapFieldModel>();
            base.Load(builder);
        }
    }
}
