namespace StandardInterfaceImplementation;
public class Mother(string name, short age, int qtdeChild): IPeople
{
	public string Name { get; set; } = name;
	public short Age { get; set; } = age;
	public int QtdeChild { get; set; } = qtdeChild;


	public decimal GetBenefit()
	{
		if (!NoNecessaryChildren())
			throw new Exception("Value incorret");

		if (!IsAdult())
			throw new Exception("Not adult");

		if (string.IsNullOrEmpty(Name))
			throw new Exception("Name is empty");

		return 1400;
	}

	bool NoNecessaryChildren() => QtdeChild >= 0;

	private bool IsAdult() => Age >= 18;
}
