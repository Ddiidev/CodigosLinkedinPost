
# Exception or Error

Esse repositório faz parte de um post publicado no, que pode ser encontrado [✅ Exception or Result](https://www.linkedin.com/posts/andreluizss_tabnews-activity-7186781671738798080-Fxos).

Abaixo demosto que utilizar exceptions pode tornar a execução de uma aplicação mais pesada em caso de falhas.

> [!NOTE]
> Para o caso em que utilizei sem exceção, fiz de modo muito ingênuo, aconselho a utilizar o [fluat](https://github.com/andrebaltieri/Flunt)

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3447/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12450H, 1 CPU, 12 logical and 8 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2


```
| Method               | Mean         | Error        | StdDev       | Gen0   | Allocated |
|--------------------- |-------------:|-------------:|-------------:|-------:|----------:|
| RunWithExceptions    | 78,358.34 ns | 1,551.354 ns | 2,988.932 ns | 0.1221 |     824 B |
| RunWithoutExceptions |     32.63 ns |     0.373 ns |     0.331 ns | 0.0485 |     304 B |
