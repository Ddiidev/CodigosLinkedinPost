using System.Reflection;

namespace ReferenceVsPointer;

internal class Program
{
	static void Main(string[] args)
	{
		CodeSafe();
		CodeUnsafe();
	}

	public static void CodeSafe()
	{
		Console.WriteLine($"{MethodBase.GetCurrentMethod()?.Name} - Without references");
		var myStruct = new MyStruct(20);
		var myAnotherStruct = myStruct;
		myAnotherStruct.Age = 26;

		Console.WriteLine(myStruct.Age);
		Console.WriteLine(myAnotherStruct.Age);

		Console.WriteLine(string.Concat(Enumerable.Repeat("-", 15)));
	}

	public unsafe static void CodeUnsafe()
	{
		Console.WriteLine($"{MethodBase.GetCurrentMethod()?.Name} - With references");
		var myStruct = new MyStruct(20);
		MyStruct* myStructPtr = &myStruct;
		myStructPtr->Age = 26;

		Console.WriteLine(myStruct.Age);
		Console.WriteLine(myStructPtr->Age);

		Console.WriteLine(string.Concat(Enumerable.Repeat("-", 15)));
	}

	public struct MyStruct(int age)
	{
		public int Age = age;
	}
}
