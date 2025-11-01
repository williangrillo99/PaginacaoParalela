using Microsoft.Extensions.DependencyInjection; 
using Refit;                                     
using Domain.Interface;                        
using Infra.Repositories;                       
using Infra.Http;
using Microsoft.Extensions.Http.Resilience;

namespace Infra;

public static class DependencyInjection
{
    public static IServiceCollection AddInfra(this IServiceCollection services)
    {
        services.AddScoped<IPersonagemRepository, PersonagemRepository>();
        AdicionarApiRickMory(services);
        return services;
    }

    private static void AdicionarApiRickMory(IServiceCollection services)
    {
        services
            .AddRefitClient<IRickMoryApi>()
            .ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri("https://rickandmortyapi.com/api");

                client.Timeout = TimeSpan.FromSeconds(500); // timeout do HttpClient
            }).AddStandardResilienceHandler()
            .Configure(o =>
            {
                o.TotalRequestTimeout.Timeout = TimeSpan.FromSeconds(90);

                o.Retry.MaxRetryAttempts = 1;
            });
    }
}