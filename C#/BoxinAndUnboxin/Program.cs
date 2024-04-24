namespace BoxinAndUnboxin;

internal static class Program
{
	static unsafe void Main()
	{
		using var obj = new Any();

		obj.Put("André");
		Console.WriteLine(obj.Get<string>());

		obj.Put(33.33m);
		Console.WriteLine(obj.Get<decimal>());

		obj.Put(new People
		{
			Name = "André",
			Age = 26
		});
		var p = obj.Get<People>();
		Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");

		obj.Put(3);
		Console.WriteLine(obj.Get<bool>());

		obj.Put(false);
		Console.WriteLine(obj.Get<int>());
	}

	public class People
	{
		public string Name = string.Empty;
		public int Age;
	}
}
