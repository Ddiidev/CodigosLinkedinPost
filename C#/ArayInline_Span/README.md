Esse é um projeto baseado em um post no linkedin, é possível encontra-lo aqui: [✅ ArraInlineAndSpan](https://www.linkedin.com/posts/andreluizss_c-tip-arrayinline-e-spant-escova%C3%A7%C3%A3o-activity-7185653613392777218-XjMb)

Este é um exemplo de código utlizando o novo atributo ArrayInline do .NET 9.
E o Span<T> e stckalloc que é relativamente antigo.

stackalloc consegue ser relativamente mais rápido que ArrayInline, porém ArrayInline pode ser extremamente mais flexível.
Para tipos primitivos, é possível ter um ganho, mas para tipos gerenciados não é possível utilizar com stackalloc.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3447/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12450H, 1 CPU, 12 logical and 8 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 9.0.0 (9.0.24.17209), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.17209), X64 RyuJIT AVX2

```
| Method         | Mean     | Error   | StdDev  | Allocated |
|--------------- |---------:|--------:|--------:|----------:|
| RunInlineArray | 169.6 ns | 3.44 ns | 4.59 ns |         - |
| RunSpan        | 167.5 ns | 3.32 ns | 4.07 ns |         - |
