namespace PIM_4_Semestre.Models.Entities
{
    public class CarrinhoCompras
    {
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }

        public CarrinhoCompras(string nomeProduto, int quantidade)
        {
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
        }

        public int AtualizarQuant(int quant)
        {
            return quant;
        }

        public override string ToString()
        {
            return $"Produto: {NomeProduto}" +
                   $"Quantidade: {Quantidade}";
        }
    }
}
