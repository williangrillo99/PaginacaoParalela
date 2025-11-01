using Application;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Infra;

namespace Api.Benchmarks.Controllers;


[SimpleJob(runtimeMoniker: RuntimeMoniker.Net90, warmupCount: 1, iterationCount: 5, invocationCount: 1)]
[MemoryDiagnoser]
public class ListagemBenchmark
{
    private ServiceProvider _provider = default!;
    private IListagemPaginacaoAppService _service = default!;

    [GlobalSetup]
    public void Setup()
    {
        var services = new ServiceCollection();

        services.AddApplication();
        services.AddInfra(); 

        _provider = services.BuildServiceProvider();

        _service = _provider.GetRequiredService<IListagemPaginacaoAppService>();
    }


    [Benchmark(Description = "Execução Assíncrona (sequencial)")]
    public async Task PaginacaoAsync()
    {
        await _service.PaginacaoAsync(CancellationToken.None);
    }

    [Benchmark(Description = "Execução Paralela (WhenAll)")]
    public async Task PaginacaoParalelaAsync()
    {
        await _service.PaginacaoParalelaAsync(CancellationToken.None);
    }
}