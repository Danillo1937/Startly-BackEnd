using System.Diagnostics;

namespace Startly.Domain.DTOs.Adicionar.StartupAdicionarDto
{
    public class StartupContatoAdicionarDto
    {
        public Guid StartupId { get; set; }
        public string? ConfirmarEmail { get; set; }
    }
}
