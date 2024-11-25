namespace PIM_4_Semestre.Models.Entities
{
    public class Produto : CarrinhoCompras
    {
        private int quantidade1;

        public string NomeProduto { get; set; }
        public int QtdProduto { get; set; }

        public double Preco { get; set; }

        public Produto(string nomeProduto, int qtdProduto, double preco, int quantidade)
            : base(nomeProduto, quantidade)
        {
            NomeProduto = nomeProduto;
            QtdProduto = qtdProduto;
            Preco = preco;
        }

        public Produto(string nomeProduto, int qtdProduto, double preco, int quantidade, int quantidade1) : this(nomeProduto, qtdProduto, preco, quantidade)
        {
            this.quantidade1 = quantidade1;
        }

        public double Subtotal()
        {
            return Preco * QtdProduto;
        }
    }
}
