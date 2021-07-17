using System;
using InfoProducer.Infra.IoC.BootStrapper;
using Microsoft.Extensions.DependencyInjection;

namespace InfoProducer.Api.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            InjectorBootStrapper.RegisterContainerServices(services);
        }
    }
}