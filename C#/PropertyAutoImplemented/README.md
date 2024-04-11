Esse é um projeto baseado em um post no linkedin, é possível encontra-lo aqui: [✅ PropertysPure](https://www.linkedin.com/posts/andreluizss_c-tip-propriedades-auto-implementadas-activity-7184231360683773952-928M)

E no projeto vou mostrar que para um VO(Value Object) não é necessário um `{get; set;}` auto implementado.

Abaixo é possível ver o resultado:
```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3374/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12450H, 1 CPU, 12 logical and 8 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2


```
| Method                      | Mean      | Error     | StdDev    | Gen0   | Allocated |
|---------------------------- |----------:|----------:|----------:|-------:|----------:|
| RunPure                     | 0.7486 ns | 0.0420 ns | 0.0373 ns | 0.0038 |      24 B |
| RunProperttyAutoImplemented | 1.4769 ns | 0.0311 ns | 0.0290 ns | 0.0038 |      24 B |
