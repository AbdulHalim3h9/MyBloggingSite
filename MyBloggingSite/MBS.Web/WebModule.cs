using Autofac;
using AutoMapper;
using MBS.Infrastructure.DbContexts;
using MBS.Infrastructure.Repositories;

namespace MBS.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BlogRepository>().AsSelf();
            //builder.RegisterType<BlogDbContext>().AsSelf();
            //builder.RegisterType<IMapper>
        }
    }
}
