namespace PIM_4_Semestre.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public LoginModel(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}
