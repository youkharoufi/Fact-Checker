using FactChecker.Api.Application.UseCases;
using FactChecker.Api.Application.UseCases.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FactChecker.Api.Application
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IAudioToTextUseCases, AudioToTextUseCases>();

            return services;
        }
    }
}
