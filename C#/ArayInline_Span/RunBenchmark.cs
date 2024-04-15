using BenchmarkDotNet.Attributes;

using System.Runtime.CompilerServices;

namespace Teste;

[MemoryDiagnoser]
public class RunBenchmark
{

	[Benchmark]
	public void RunInlineArray()
	{
		int value = 0;
		var x = new MyArr<int>();

		for (int i = 0; i < 300; i++)
			x[i] = i;

		for (int i = 0; i < 300; i++)
			value = x[i];
	}

	[Benchmark]
	public void RunSpan()
	{
		int value = 0;
		Span<int> x = stackalloc int[300];

		for (int i = 0; i < 300; i++)
			x[i] = i;

		for (int i = 0; i < 300; i++)
			value = x[i];
	}
}

[InlineArray(300)]
public struct MyArr<T>
{
	private T element;
}