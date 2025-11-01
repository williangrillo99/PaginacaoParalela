using Application;
using BenchmarkDotNet.Attributes;
using Infra;

namespace Api.Benchmarks.Controllers;

[MemoryDiagnoser, RankColumn]
[WarmupCount(1)]
[IterationCount(5)] 
public class ListagemBenchmark
{
    private ServiceProvider _provider = default!;
    private IListagemPaginacaoAppService _service = default!;

    [GlobalSetup]
    public void Setup()
    {
        var services = new ServiceCollection();

        services.AddApplication(); // seu extension method
        services.AddInfra();       // seu extension method (repos, Refit, etc.)

        _provider = services.BuildServiceProvider();

        // Resolve o serviço que você quer medir
        _service = _provider.GetRequiredService<IListagemPaginacaoAppService>();
    }

    [GlobalCleanup]
    public void Cleanup()
    {
        _provider.Dispose();
    }

    [Benchmark(Description = "Execução Assíncrona (sequencial)")]
    public async Task PaginacaoAsync()
        => await _service.PaginacaoAsync(CancellationToken.None);

    [Benchmark(Description = "Execução Paralela (WhenAll)")]
    public async Task PaginacaoParalelaAsync()
        => await _service.PaginacaoParalelaAsync(CancellationToken.None);
}