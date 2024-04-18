namespace ExceptionOrResult.WithException;
public interface IPeople
{
    public string Name { get; set; }
    public short Age { get; set; }
    public int QtdeChild { get; set; }

    public decimal GetBenefit();
}
