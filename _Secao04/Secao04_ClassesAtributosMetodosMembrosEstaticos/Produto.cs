using System;
using System.Collections.Generic;
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
            return total;
        }
        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }
    }
}