
using System.Globalization;


namespace exercicio_produtos
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _qtd;

        public Produto (string nome, double preco, int qtd)
        {
            _nome = nome;
            _preco = preco;
            _qtd = qtd;
        }




        public double ValorEmEstoque() { 
        return _preco * _qtd; 
        }

        public void AdicionarProduto(int quantidade) {
            _qtd += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            _qtd -= quantidade;
        }



        public override string ToString()
        {
            return _nome + ", " 
                + _qtd + " und. " 
                + " - Valor unitário: R$" 
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + " - TOTAL EM ESTOQUE: R$" 
                + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);           
        }


      
    }
}
