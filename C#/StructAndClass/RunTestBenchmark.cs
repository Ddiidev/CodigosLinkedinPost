using BenchmarkDotNet.Attributes;

namespace StructAndClass;

[MemoryDiagnoser]
public class RunTestBenchmark
{
	[Benchmark]
	public void ConstructPessoaWithClass()
	{
		var p = new ProductClass("Coxinha", 3.5m, 0.5m, 3);

	}

	public void IncrementOneOnPrice(ref ProductClass p)
	{
		p.Price++;
	}

	public void IncrementOneOnPrice(ref ProductStruct p)
	{
		p.Price++;
	}

	[Benchmark]
	public void ConstructPessoaWithStruct()
	{
		_ = new ProductStruct("Coxinha", 3.5m, 0.5m, 3);
	}
}
