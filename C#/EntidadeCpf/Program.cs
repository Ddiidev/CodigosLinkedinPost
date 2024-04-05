
try
{
	var cpfClientes = new List<Cpf>();
	cpfClientes.Add("540.297.530-27");
	cpfClientes.Add("867.758.450-13");
} catch (Exception ex)
{
	Console.WriteLine(ex.ToString());
}


public class Cpf
{
	private string Cpf_;
	public Cpf(string cpf)
	{
		Cpf_ = cpf;
	}

	public static implicit operator Cpf(string cpf)
	{
		if (!CpfValido(cpf))
			throw new Exception($@"Cpf ""{cpf}"" é inválido");

		return new Cpf(cpf);
	}

	public static implicit operator string(Cpf cpf) => cpf.Cpf_;

	static bool CpfValido(string cpf)
	{
		int[] multiplicador1 = [10, 9, 8, 7, 6, 5, 4, 3, 2];
		int[] multiplicador2 = [11, 10, 9, 8, 7, 6, 5, 4, 3, 2];
		string tempCpf, digito;
		int soma, resto;

		cpf = cpf.Trim().Replace(".", "").Replace("-", "");
		if (cpf.Length != 11)
			return false;
		tempCpf = cpf[..9];
		soma = 0;

		for (int i = 0; i < 9; i++)
			soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
		resto = soma % 11;
		if (resto < 2)
			resto = 0;
		else
			resto = 11 - resto;
		digito = resto.ToString();
		tempCpf += digito;
		soma = 0;
		for (int i = 0; i < 10; i++)
			soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
		resto = soma % 11;
		if (resto < 2)
			resto = 0;
		else
			resto = 11 - resto;
		digito += resto.ToString();
		return cpf.EndsWith(digito);
	}
}

