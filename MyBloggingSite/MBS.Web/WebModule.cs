using Autofac;
using MBS.Infrastructure.Repositories;

namespace MBS.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BlogRepository>().AsSelf();
        }
    }
}
