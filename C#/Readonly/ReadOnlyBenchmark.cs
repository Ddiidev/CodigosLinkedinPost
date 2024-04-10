using BenchmarkDotNet.Attributes;

namespace Readonly;
public class ReadOnlyBenchmark
{
	public static readonly string Nome = string.Concat(Enumerable.Repeat("A", 1000));
	public static string NomeExp => string.Concat(Enumerable.Repeat("A", 1000));

	[Benchmark]
	public string AcessarNomeComPalavraChaveReadonly()
	{
		return ReadOnlyBenchmark.Nome;
	}

	[Benchmark]
	public string AcessarNomeExpression()
	{
		return ReadOnlyBenchmark.NomeExp;
	}
}
