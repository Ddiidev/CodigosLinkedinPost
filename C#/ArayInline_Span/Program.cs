using System.Runtime.CompilerServices;

namespace Teste;

internal class Program
{
	static void Main()
	{
		_ = BenchmarkDotNet.Running.BenchmarkRunner.Run<RunBenchmark>();
	}
}
