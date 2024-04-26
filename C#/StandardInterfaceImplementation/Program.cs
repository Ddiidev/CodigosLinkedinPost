using StandardInterfaceImplementation;

namespace ExceptionOrResult;

internal static class Program
{
	static void Main()
	{
		IPeople people = new Father("João", 18, 1);

		Console.WriteLine(people.GetBenefit());

		people = new Mother("Maria", 20, 1);

		Console.WriteLine(people.GetBenefit());

	}
}
