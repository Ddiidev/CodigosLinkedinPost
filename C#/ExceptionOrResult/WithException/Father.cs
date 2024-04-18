namespace ExceptionOrResult.WithException;
public class Father(string name, short age, int qtdeChild): IPeople
{
	public string Name { get; set; } = name;
	public short Age { get; set; } = age;
	public int QtdeChild { get; set; } = qtdeChild;

	public decimal GetBenefit()
	{
		if (!MoreThanTwoChildre())
			throw new Exception("Not enough children");

		if (!IsAdult())
			throw new Exception("Not adult");

		if (string.IsNullOrEmpty(Name))
			throw new Exception("Name is empty");

		return 1400;
	}

	bool MoreThanTwoChildre() => QtdeChild > 2;

	private bool IsAdult() => Age >= 18;
}
