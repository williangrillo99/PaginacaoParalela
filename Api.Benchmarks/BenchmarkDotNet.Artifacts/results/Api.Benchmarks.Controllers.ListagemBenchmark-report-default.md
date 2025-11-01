
BenchmarkDotNet v0.15.5, macOS 26.0.1 (25A362) [Darwin 25.0.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.1, 9.0.124.61010), Arm64 RyuJIT armv8.0-a
  Job-OITBKU : .NET 9.0.1 (9.0.1, 9.0.124.61010), Arm64 RyuJIT armv8.0-a

MinIterationTime=500ms  IterationCount=8  WarmupCount=3  

 Method                             | Mean | Error |
----------------------------------- |-----:|------:|
 'Execução Assíncrona (sequencial)' |   NA |    NA |
 'Execução Paralela (WhenAll)'      |   NA |    NA |

Benchmarks with issues:
  ListagemBenchmark.'Execução Assíncrona (sequencial)': Job-OITBKU(MinIterationTime=500ms, IterationCount=8, WarmupCount=3)
  ListagemBenchmark.'Execução Paralela (WhenAll)': Job-OITBKU(MinIterationTime=500ms, IterationCount=8, WarmupCount=3)
