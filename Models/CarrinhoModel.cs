namespace PIM_4_Semestre.Models
{
    public class CarrinhoModel
    {
        public string Nome_Produto { get; set; }

        public CarrinhoModel(string nome_Produto)
        {
            Nome_Produto = nome_Produto;
        }
    }
}
