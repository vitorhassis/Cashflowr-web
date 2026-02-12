namespace Cashflowr.Data.Dtos
{
    public class ReadUsuarioDto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool IsAtivo { get; set; }
    }
}
