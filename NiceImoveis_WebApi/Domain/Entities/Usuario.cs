namespace NiceImoveis_WebApi.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeDoUsuario { get; set; }
        public string EmailDoUsuario { get; set; }
        public string SenhaDoUsuario { get; set; }
    }
}
