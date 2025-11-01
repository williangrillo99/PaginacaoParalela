```

BenchmarkDotNet v0.15.5, macOS 26.0.1 (25A362) [Darwin 25.0.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.1, 9.0.124.61010), Arm64 RyuJIT armv8.0-a
  Job-XZKGNT : .NET 9.0.1 (9.0.1, 9.0.124.61010), Arm64 RyuJIT armv8.0-a

Runtime=.NET 9.0  InvocationCount=1  IterationCount=5  
UnrollFactor=1  WarmupCount=1  

```
| Method                             | Mean       | Error     | StdDev    | Allocated |
|----------------------------------- |-----------:|----------:|----------:|----------:|
| &#39;Execução Assíncrona (sequencial)&#39; | 2,671.5 ms | 463.48 ms | 120.36 ms |  878.3 KB |
| &#39;Execução Paralela (WhenAll)&#39;      |   178.4 ms |  88.49 ms |  13.69 ms | 795.09 KB |
