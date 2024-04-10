using BenchmarkDotNet.Running;

namespace Readonly;

internal static class Program
{
	static void Main()
	{
		var summary = BenchmarkRunner.Run<ReadOnlyBenchmark>();
	}
}
