using Api.Benchmarks.Controllers;
using BenchmarkDotNet.Running;

namespace Api.Benchmarks;

public abstract class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<ListagemBenchmark>();
    }
}