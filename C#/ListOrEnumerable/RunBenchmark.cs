using BenchmarkDotNet.Attributes;

namespace ListOrEnumerable;

[MemoryDiagnoser]
public class RunBenchmark
{

	[Benchmark]
	public void ConsumeEnumerable()
	{
		var products = ReturnEnumerableProducts();
		var countProducts = products.Count();

		if (countProducts > 0)
		{
			foreach (var item in products)
			{
				var x = item;
				x.Price++; // example
						   // Console.WriteLine(item);
			}
		}
	}

	[Benchmark]
	public void ConsumeEnumerableToList()
	{
		var products = ReturnListProductsWithoutCapacity().ToList();
		var countProducts = products.Count;

		if (countProducts > 0)
		{
			foreach (var item in products)
			{
				var x = item;
				x.Price++; // example
						   // Console.WriteLine(item);
			}
		}
	}

	[Benchmark]
	public void ConsumeListWithCapacity()
	{
		var products = ReturnListProductsWithCapacity();
		var countProducts = products.Count;

		if (countProducts > 0)
		{
			foreach (var item in products)
			{
				var x = item;
				x.Price++; // example
						   // Console.WriteLine(item);
			}
		}
	}

	[Benchmark]
	public void ConsumeListWithoutCapacity()
	{
		var products = ReturnListProductsWithoutCapacity();
		var countProducts = products.Count;

		if (countProducts > 0)
		{
			foreach (var item in products)
			{
				var x = item;
				x.Price++; // example
						   // Console.WriteLine(item);
			}
		}
	}

	IEnumerable<Produtos> ReturnEnumerableProducts()
	{
		const int max = 90000;

		for (int i = 0; i < max; i++)
		{
			yield return new Produtos
			{
				Id = Guid.NewGuid(),
				Nome = $"Teste {i}",
				Price = 10.33m + i
			};
		}
	}

	List<Produtos> ReturnListProductsWithoutCapacity()
	{
		const int max = 90000;
		var list = new List<Produtos>();

		for (int i = 0; i < max; i++)
		{
			list.Add(new Produtos
			{
				Id = Guid.NewGuid(),
				Nome = $"Teste {i}",
				Price = 10.33m + i
			});
		}

		return list;
	}

	List<Produtos> ReturnListProductsWithCapacity()
	{
		const int max = 90000;
		var list = new List<Produtos>(max);

		for (int i = 0; i < max; i++)
		{
			list.Add(new Produtos
			{
				Id = Guid.NewGuid(),
				Nome = $"Teste {i}",
				Price = 10.33m + i
			});
		}

		return list;
	}
}
