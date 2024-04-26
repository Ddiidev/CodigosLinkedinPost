namespace StandardInterfaceImplementation;
public class Father(string name, short age, int qtdeChild): IPeople
{
	public string Name { get; set; } = name;
	public short Age { get; set; } = age;
	public int QtdeChild { get; set; } = qtdeChild;
}
