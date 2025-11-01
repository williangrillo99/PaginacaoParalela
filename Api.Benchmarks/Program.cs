// See https://aka.ms/new-console-template for more information

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