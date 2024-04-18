namespace ExceptionOrResult.WithoutException;
public interface IPeople
{
    public string Name { get; set; }
    public short Age { get; set; }
    public int QtdeChild { get; set; }

    public (List<string> msgErrors, decimal benefit) GetBenefit();
}
