using System.Diagnostics;

namespace Startly.Domain.DTOs.Startup
{
    public class StartupContatoAdicionarDTO
    {
        public Guid StartupId { get; set; }
        public string? ConfirmarEmail { get; set; } 
    }
}
