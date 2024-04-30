# List or Enumerable

Esse é um projeto baseado em um post no linkedin, é possível encontra-lo aqui: [✅ List or Enumerable](https://www.linkedin.com/posts/andreluizss_pare-de-usar-listt-listt-ou-enumerable-activity-7191119561176367105-MK6i)

E no projeto vou mostrar quatro exemplos de consumir uma lista de produtos.

Abaixo é possível ver o resultado:

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3527/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12450H, 1 CPU, 12 logical and 8 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 9.0.0 (9.0.24.17209), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.17209), X64 RyuJIT AVX2


```
| Method                     | Mean     | Error    | StdDev   | Gen0      | Gen1      | Gen2     | Allocated |
|--------------------------- |---------:|---------:|---------:|----------:|----------:|---------:|----------:|
| ConsumeEnumerable          | 16.04 ms | 0.287 ms | 0.269 ms | 2968.7500 |         - |        - |  17.84 MB |
| ConsumeEnumerableToList    | 30.16 ms | 0.438 ms | 0.365 ms | 2000.0000 | 1468.7500 | 687.5000 |  11.61 MB |
| ConsumeListWithCapacity    | 24.91 ms | 0.392 ms | 0.367 ms | 1625.0000 | 1062.5000 | 437.5000 |   9.61 MB |
| ConsumeListWithoutCapacity | 33.33 ms | 0.652 ms | 1.052 ms | 2000.0000 | 1250.0000 | 500.0000 |  10.92 MB |
