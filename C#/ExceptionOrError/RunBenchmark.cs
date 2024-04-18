using BenchmarkDotNet.Attributes;

namespace ExceptionOrResult;

[MemoryDiagnoser]
public class RunBenchmark
{
	[Benchmark]
	public void RunWithExceptions()
	{
		try
		{
			WithException.IPeople father = new WithException.Father("Pai", 19, 1);

			var benefit = father.GetBenefit();
		} catch (Exception ex)
		{
		}

		try
		{
			WithException.IPeople mother = new WithException.Mother("Mãe", 18, -1);

			var benefit = father.GetBenefit();
		} catch (Exception ex)
		{
			Console.WriteLine($"Error => {ex.Message}");
		}
	}

	[Benchmark]
	public void RunWithoutExceptions()
	{
		var viewMsgs = (List<string> msgs) => msgs.ForEach(msg => Console.WriteLine($"Error => {msg}"));

		WithoutException.IPeople father = new WithoutException.Father("Pai", 19, 1);

		var resulteBenefitFather = father.GetBenefit();

		if (resulteBenefitFather.msgErrors.Count > 0)
			viewMsgs(resulteBenefitFather.msgErrors);

		_ = resulteBenefitFather.benefit;


		WithoutException.IPeople mother = new WithoutException.Mother("Mãe", 18, -1);

		var resulteBenefitMother = father.GetBenefit();

		if (resulteBenefitMother.msgErrors.Count > 0)
			viewMsgs(resulteBenefitMother.msgErrors);

		_ = resulteBenefitMother.benefit;
	}
}
