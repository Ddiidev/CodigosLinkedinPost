
# Readonly

Esse é um projeto baseado em um post no linkedin, é possível encontra-lo aqui: [Linkedin]()

E no projeto mostro dois modos de criar propriedades somente leitura.

Abaixo é possível ver o resultado:
```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3374/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12450H, 1 CPU, 12 logical and 8 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2


```
| Method                             | Mean          | Error      | StdDev     |
|----------------------------------- |--------------:|-----------:|-----------:|
| AcessarNomeComPalavraChaveReadonly |     0.6297 ns |  0.0240 ns |  0.0213 ns |
| AcessarNomeExpression              | 1,353.7207 ns | 22.8915 ns | 20.2927 ns |
