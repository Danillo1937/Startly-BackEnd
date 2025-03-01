using Startly.Domain.DTOs.Atualizar.StartupAtualizarDto;
using Startly.Domain.Entities;
using Startly.Enumerators;

namespace Startly.Domain.DTOs.Deletar.StartupDeletarDto
{
    public class StartupDeletarDTO
    {
        public Guid id { get; set; }

        public List<StartupAtuacaoAtualizarDto> Atuacoes { get; set; } = [];
        public List<StartupVideoAtualizarDto> Videos { get; set; } = [];
        public List<StartupImagemAtualizarDto> Imagens { get; set; } = [];
        public List<StartupContatoAtualizarDto> Contatos { get; set; } = [];

    }
}
