```

BenchmarkDotNet v0.15.5, macOS 26.0.1 (25A362) [Darwin 25.0.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.1, 9.0.124.61010), Arm64 RyuJIT armv8.0-a
  Job-MEHJPP : .NET 9.0.1 (9.0.1, 9.0.124.61010), Arm64 RyuJIT armv8.0-a

IterationCount=5  WarmupCount=1  

```
| Method                             | Mean | Error | Rank |
|----------------------------------- |-----:|------:|-----:|
| &#39;Execução Assíncrona (sequencial)&#39; |   NA |    NA |    ? |
| &#39;Execução Paralela (WhenAll)&#39;      |   NA |    NA |    ? |

Benchmarks with issues:
  ListagemBenchmark.'Execução Assíncrona (sequencial)': Job-MEHJPP(IterationCount=5, WarmupCount=1)
  ListagemBenchmark.'Execução Paralela (WhenAll)': Job-MEHJPP(IterationCount=5, WarmupCount=1)
