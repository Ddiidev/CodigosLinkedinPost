namespace ExceptionOrResult.WithoutException;
public class Father(string name, short age, int qtdeChild): IPeople
{
	public string Name { get; set; } = name;
	public short Age { get; set; } = age;
	public int QtdeChild { get; set; } = qtdeChild;

	bool MoreThanTwoChildre() => QtdeChild > 2;

	private bool IsAdult() => Age >= 18;

	public (List<string> msgErrors, decimal benefit) GetBenefit()
	{
		List<string> msgErrors = [];

		if (!MoreThanTwoChildre())
			msgErrors.Add("Not enough children");

		if (!IsAdult())
			msgErrors.Add("Not adult");

		if (string.IsNullOrEmpty(Name))
			msgErrors.Add("Name is empty");

		return (new List<string>(), 1400);
	}
}
