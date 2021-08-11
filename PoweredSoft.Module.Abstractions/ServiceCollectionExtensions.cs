using Microsoft.Extensions.DependencyInjection;

namespace PoweredSoft.Module.Abstractions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddModule<T>(this IServiceCollection services)
            where T : IModule, new()
        {
            var module = new T();
            return module.ConfigureServices(services);
        }
    }
}
