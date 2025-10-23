using Microsoft.Extensions.DependencyInjection; 
using Refit;                                     
using Domain.Interface;                        
using Infra.Repositories;                       
using Infra.Http;                               

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
            })
            .AddStandardResilienceHandler(); 
    }
}