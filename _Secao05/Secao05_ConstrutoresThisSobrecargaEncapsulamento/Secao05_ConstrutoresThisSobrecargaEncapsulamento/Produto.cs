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
		//Ecapsulamento
		/*
			É um princípio que consiste em esconder detalhes
		    de implementação de um componente(objeto), expondo
		    apenas operações seguras e que o mantenha em um estado
		    consistente.
			O objeto deve sempre estar em um estado consistente,
		    e a própria classe deve garantir isso.
		 */

		//this é uma referência
		private string _nome;
		private double _preco;
		private int _quantidade;

		public Produto() { }
		public Produto(string nome, double preco, int quantidade) : this() //referenciar outro construtor em um construtor
		{
			this._nome = nome; //this para diferenciar atributos das variáveis
			this._preco = preco;
			this._quantidade = quantidade;
		}
		public Produto(string nome, double preco)
		{
			_nome = nome;
			_preco = preco;
			_quantidade = 0;
		}

		public double ValorTotalEmEstoque()
		{
			return _preco * _quantidade;
		}
		public void AdicionarProdutos(int quantidade)
		{
			_quantidade +=  quantidade;
		}
		public void RemoverProdutos(int quantidade)
		{
			_quantidade -= quantidade;
		}
		public override string ToString()
		{
			return _nome + ", $ "+ _preco.ToString("F2", CultureInfo.InvariantCulture) + ", "+ _quantidade + ", unidades, Total: $"+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
