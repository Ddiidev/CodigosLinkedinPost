using BenchmarkDotNet.Running;

namespace ObjectOrDynamic;

internal static class Program
{
	static void Main(string[] args)
	{
		BenchmarkRunner.Run<RunBenchmark>();
	}
}
