
# StructAndClass

Esse é um projeto baseado em um post no linkedin, é possível encontra-lo aqui: [✅ StructAndClass]()

E no projeto mostro dois modos de representar uma estrutura Produto, usando classe / struct.

Uma melhora de 5.53 ns, com zero alocações e o garbage colector nem precisou trabalhar!

Abaixo é possível ver o resultado:
```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3374/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12450H, 1 CPU, 12 logical and 8 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2


```
| Method                    | Mean     | Error    | StdDev   | Gen0   | Allocated |
|-------------------------- |---------:|---------:|---------:|-------:|----------:|
| ConstructPessoaWithClass  | 47.38 ns | 0.570 ns | 0.533 ns | 0.0127 |      80 B |
| ConstructPessoaWithStruct | 41.85 ns | 0.434 ns | 0.406 ns |      - |         - |
