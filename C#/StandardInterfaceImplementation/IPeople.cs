namespace StandardInterfaceImplementation;
public interface IPeople
{
    public string Name { get; set; }
    public short Age { get; set; }
    public int QtdeChild { get; set; }

    public decimal GetBenefit()
    {
        return Age <= 19 && QtdeChild  >= 1 ? 500 : 0;
    }
}
