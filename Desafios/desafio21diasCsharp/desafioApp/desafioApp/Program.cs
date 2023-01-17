// See https://aka.ms/new-console-template for more information
namespace console;
public class Program 
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Olá Mundo");
		var x = 0;
		string templatestring =
			$"""
			Testando novo template string
			do dotnet7
			o valor de x é: {x}
			""";

		// Uso de $$ para interpretar a formatação do json
		string templatejson =
			$$"""
				{
					"employees":[
						{"firstName": "John", "lastName": "Doe - {{x}}"},
						{"firstName": "Anna", "lastName": "Smith - {{x}}"},
						{"firstName": "Peter", "lastName": "Jones - {{x}}"}
					]
				}
			""";
		Console.WriteLine(templatestring);
	}
	
}

