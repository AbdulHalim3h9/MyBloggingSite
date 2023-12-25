using Autofac;
using MBS.Infrastructure.DbContexts;
using MBS.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Infrastructure
{
    public class InfrastructureModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public InfrastructureModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BlogDbContext>().AsSelf()
            .WithParameter("connectionString", _connectionString)
            .WithParameter("migrationAssemblyName", _migrationAssemblyName)
            .InstancePerLifetimeScope();
            //builder.RegisterType<IMapper>
        }
    }

}
