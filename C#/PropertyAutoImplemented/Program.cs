using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace PropertyAutoImplemented;

internal class Program
{
	static void Main(string[] args)
	{
		var summary = BenchmarkRunner.Run<TestPropertys>();
	}
}
