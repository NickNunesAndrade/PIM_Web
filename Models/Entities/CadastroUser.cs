namespace PIM_4_Semestre.Models.Entities
{
    public class CadastroUser : Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int NumeroTelefone { get; set; }
        public string Email { get; set; }
        public int Senha { get; set; }

        public CadastroUser(int id, string nome, int idade, int numeroTelefone, string email, int senha, string nomeProduto, int num_id_prod, int qtd_produto, int numProduto, int quantidade)
            : base (nomeProduto, num_id_prod, qtd_produto, numProduto, quantidade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            NumeroTelefone = numeroTelefone;
            Email = email;
            Senha = senha;
        }
    }
}
