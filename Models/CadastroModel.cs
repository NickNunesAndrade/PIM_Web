namespace PIM_4_Semestre.Models
{
    public class CadastroModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public CadastroModel(string nome, string cpf, string email, string senha)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Senha = senha;
        }
    }
}
