using BenchmarkDotNet.Running;

namespace ListOrEnumerable;

internal class Program
{
	static void Main(string[] args)
	{
		_ = BenchmarkRunner.Run<RunBenchmark>();
	}
}
