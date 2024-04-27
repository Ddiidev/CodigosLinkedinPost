namespace RegexLabel;

using System;
using System.Text.RegularExpressions;

public static class RegexLabel
{
	public static void Main()
	{
		const string pattern = @"(?<tipo>\S+)(\s+|)((?<parcelas>\d)|)";
		const string input = "Débito";
		var tipo = "";
		var parcelas = 0;

		var m = Regex.Match(input, pattern);

		tipo = m.Groups["tipo"].Value;
		int.TryParse(m.Groups["parcelas"].Value, out parcelas);


		Console.WriteLine($"tipo: {tipo} parcelas: {parcelas}");
	}
}
