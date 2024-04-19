# Object or Dynamic

Esse projeto faz parte de uma publicação feita no Linkedin, que pode ser encontrado aqui: [✅ ObjectOrDynamic](https://www.linkedin.com/posts/andreluizss_object-or-dynamic-activity-7187075162280714240-jaAw)

A seguir, apresento a comparação entre o desempenho do tipo de dado "object" em relação ao tipo "dynamic". Profissionais com experiência reconhecem de forma instintiva a diferença, no entanto, é importante destacar essa distinção por meio de métricas.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3447/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12450H, 1 CPU, 12 logical and 8 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 9.0.0 (9.0.24.17209), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.17209), X64 RyuJIT AVX2


```
| Method                   | Mean      | Error    | StdDev   | Gen0   | Allocated |
|------------------------- |----------:|---------:|---------:|-------:|----------:|
| RunWithObject            |  60.82 ns | 1.226 ns | 2.114 ns | 0.0382 |     240 B |
| RunWithObjectUniqueType  |  27.47 ns | 0.908 ns | 2.650 ns | 0.0217 |     136 B |
| RunWithDynamic           | 111.22 ns | 0.980 ns | 2.477 ns | 0.0880 |     552 B |
| RunWithDynamicUniqueType |  46.26 ns | 0.453 ns | 0.424 ns | 0.0331 |     208 B |
