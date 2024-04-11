using BenchmarkDotNet.Attributes;

namespace PropertyAutoImplemented;
[MemoryDiagnoser]
public class TestPropertys
{
	[Benchmark]
	public void RunPure()
	{
		_ = new PessoaPure().Nome;
	}

	[Benchmark]
	public void RunProperttyAutoImplemented()
	{
		_ = new PessoaPropertyAutoImplemented().Nome;
	}
}
