using System.Diagnostics;

namespace Parallel;

internal static class Program
{
	static void Main()
	{
		Console.WriteLine("Run | Sequential >> Parallel");
		RunBenchmark.RunSequential();
		RunBenchmark.RunParallel();
	}
}
