namespace ExceptionOrResult;

internal static class Program
{
	static void Main(string[] args)
	{
		BenchmarkDotNet.Running.BenchmarkRunner.Run<RunBenchmark>();
	}
}
