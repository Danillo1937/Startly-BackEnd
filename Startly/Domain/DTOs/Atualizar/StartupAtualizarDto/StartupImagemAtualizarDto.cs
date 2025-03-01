namespace Startly.Domain.DTOs.Atualizar.StartupAtualizarDto
{
    public class StartupImagemAtualizarDto
    {
        public Guid id { get; set; }
        public Guid StartupId { get; set; }
        public string Imagem { get; set; } = string.Empty;
    }
}
