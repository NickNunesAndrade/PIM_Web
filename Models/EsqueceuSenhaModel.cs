namespace PIM_4_Semestre.Models
{
    public class EsqueceuSenhaModel
    {
        public string Email { get; set; }

        public EsqueceuSenhaModel(string email)
        {
            Email = email;
        }
    }
}
