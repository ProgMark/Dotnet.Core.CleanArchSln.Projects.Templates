using Autofac;
using Microsoft.Extensions.Configuration;

namespace $projectname$.Presentation.Rest.Api.IOC
{
    public class ApiModule : Module
    {
        private readonly IConfiguration _configuration;

        public ApiModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}