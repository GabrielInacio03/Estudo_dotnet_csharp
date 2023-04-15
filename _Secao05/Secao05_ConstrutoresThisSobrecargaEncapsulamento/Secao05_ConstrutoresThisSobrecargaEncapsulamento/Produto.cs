using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao05_ConstrutoresThisSobrecargaEncapsulamento
{
	public class Produto
	{
		//this é uma referência
		public string Nome;
		public double Preco;
		public int Quantidade;

		public Produto() { }
		public Produto(string nome, double preco, int quantidade) : this() //referenciar outro construtor em um construtor
		{
			this.Nome = nome; //this para diferenciar atributos das variáveis
			this.Preco = preco;
			this.Quantidade = quantidade;
		}
		public Produto(string nome, double preco)
		{
			Nome = nome;
			Preco = preco;
			Quantidade = 0;
		}

		public double ValorTotalEmEstoque()
		{
			return Preco * Quantidade;
		}
		public void AdicionarProdutos(int quantidade)
		{
			Quantidade +=  quantidade;
		}
		public void RemoverProdutos(int quantidade)
		{
			Quantidade -= quantidade;
		}
		public override string ToString()
		{
			return Nome + ", $ "+ Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "+ Quantidade + ", unidades, Total: $"+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
