using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Secao04_ClassesAtributosMetodosMembrosEstaticos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            double total = Preco * Quantidade;
            return double.Parse(total.ToString("F2", CultureInfo.InvariantCulture));
        }
        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

		//sobreposição
        //Quando chamar o objeto dentro do writeline ele, implicitamente, vai chamar o método toString
        //ou seja, o override indica que essa operação esta vindo de outra classe, nesse caso da classe Object
		public override string ToString()
		{
			//Console.WriteLine("Dados do produto: {0}, $ {1}, {2} unidades, Total: $ {3}", p.Nome, p.Preco, p.Quantidade, p.ValorTotalEmEstoque());
			return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", "
                + Quantidade
                + "unidades, Preço Total em Estoque $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}