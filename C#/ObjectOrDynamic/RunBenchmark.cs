using BenchmarkDotNet.Attributes;

namespace ObjectOrDynamic;

[MemoryDiagnoser]
public class RunBenchmark
{
	public class People
	{
		public string Name = string.Empty;
		public int Age;
	}

	[Benchmark]
	public void RunWithObject()
	{
		object obj = 33;

		{
			/* INTEGER */
			var integer = (int)obj;

			var result = integer + 42;
			obj = result;

			integer = (int)obj;

			result = integer + 42;
			obj = result;

		}

		{
			/* DOUBLE */
			obj = 33.33;
			var doubleValue = (double)obj;

			var result = doubleValue + 42.42;
			obj = result;

			doubleValue = (double)obj;

			result = doubleValue + 42.42;
			obj = result;

		}

		{
			/* DECIMAL */
			obj = 33.33m;
			var decimalValue = (decimal)obj;

			var result = decimalValue + 42.42m;
			obj = result;

			decimalValue = (decimal)obj;

			result = decimalValue + 42.42m;
			obj = result;

		}

		{
			/* STRING */
			obj = "33.33";
			var strValue = (string)obj;

			var result = strValue + "42.42";
			obj = result;

			strValue = (string)obj;

			result = strValue + "42.42";
			obj = result;

		}

		{
			/* OBJECT PEOPLE */
			obj = new People { Name = "33.33", Age = 33 };
			var objValue = (People)obj;

			objValue.Name += "42.42";
			objValue.Age += 42;
			obj = objValue;

			objValue = (People)obj;

			objValue.Name += "42.42";
			obj = objValue;

		}
	}

	[Benchmark]
	public void RunWithObjectUniqueType()
	{
		object obj = new People { Name = "33.33", Age = 33 };

		var people = (People)obj;

		people.Name += "42.42";
		people.Age += 42;
		people.Name += "42.42";

	}

	[Benchmark]
	public void RunWithDynamic()
	{
		dynamic any;

		{
			any = 33;

			/* INTEGER */
			any += 42;
			any += 42;

		}

		{
			/* DOUBLE */
			any = 33.33;

			any += 42.42;
			any += 42.42;

		}

		{
			/* DECIMAL */
			any = 33.33m;

			any += 42.42m;
			any += 42.42m;

		}

		{
			/* STRING */
			any = "33.33";

			any += "42.42";
			any += "42.42";

		}

		{
			/* OBJECT PEOPLE */
			any = new People { Name = "33.33", Age = 33 };

			any.Name += "42.42";
			any.Age += 42;
			any.Name += "42.42";

		}
	}

	[Benchmark]
	public void RunWithDynamicUniqueType()
	{
		dynamic any = new People { Name = "33.33", Age = 33 };

		any.Name += "42.42";
		any.Age += 42;
		any.Name += "42.42";

	}
}
