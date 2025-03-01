namespace Startly.Domain.DTOs.Atualizar.StartupAtualizarDto
{
    public class StartupVideoAtualizarDto
    {
        public Guid Id { get; set; }    
        public Guid StartupId { get; set; }
        public string LinkVideo { get; set; } = string.Empty;
    }
}
