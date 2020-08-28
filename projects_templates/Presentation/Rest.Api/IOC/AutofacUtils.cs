using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace $projectname$.Presentation.Rest.Api.IOC
{
    public static class AutofacUtils
    {
        public static IServiceProvider RegisterAutofacAsDiContainer(this IServiceCollection services,IModule module)
        {
            services.AddAutofac();
            var builder = new ContainerBuilder();
            builder.RegisterModule(module);
            builder.Populate(services);
            var container = builder.Build();

            return new AutofacServiceProvider(container);
        }
    }
}
