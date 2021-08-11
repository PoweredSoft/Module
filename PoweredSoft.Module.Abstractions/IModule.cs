using Microsoft.Extensions.DependencyInjection;
using System;

namespace PoweredSoft.Module.Abstractions
{
    public interface IModule
    {
        IServiceCollection ConfigureServices(IServiceCollection services);
    }
}
