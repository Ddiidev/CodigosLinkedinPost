using System.Diagnostics;

namespace Parallel;
public static class RunBenchmark
{
	public static void RunParallel()
	{
		var st = new Stopwatch();

		st.Start();

		var result1="";
		var result2="";
		var result3="";

		System.Threading.Tasks.Parallel.Invoke(
			() => result1 = RequestApi1(),
			() => result2 = RequestApi2(),
			() => result3 = RequestApi3()
		);

		st.Stop();

		if (result1.StartsWith("Return") && result2.StartsWith("Return") && result3.StartsWith("Return"))
		{
			Console.WriteLine($"Parallel   : {st.Elapsed}");
		}
	}

	public static void RunSequential()
	{
		var st = new Stopwatch();

		st.Start();

		var result1 = RequestApi1();
		var result2 = RequestApi2();
		var result3 = RequestApi3();

		st.Stop();

		if (result1.StartsWith("Return") && result2.StartsWith("Return") && result3.StartsWith("Return"))
		{
			Console.WriteLine($"Sequential : {st.Elapsed}");
		}
	}

	static string RequestApi1()
	{
		Thread.Sleep(1500);

		return "Return1";
	}

	static string RequestApi2()
	{
		Thread.Sleep(1500);

		return "Return2";
	}

	static string RequestApi3()
	{
		Thread.Sleep(1500);

		return "Return3";
	}
}
