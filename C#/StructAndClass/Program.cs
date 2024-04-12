using BenchmarkDotNet.Running;

namespace StructAndClass;

internal class Program
{
	static void Main(string[] args)
	{
		var sumary = BenchmarkRunner.Run<RunTestBenchmark>();
	}
}
