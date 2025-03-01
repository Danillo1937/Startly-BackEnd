using Startly.Enumerators;

namespace Startly.Domain.DTOs.Atualizar.StartupAtualizarDto
{
    public class StartupImagemPesquisarDto
    {
        public Guid id { get; set; }
        public EnumTipoImagem TipoImagem { get; set; }
        public string Imagem { get; set; } = string.Empty;
    }
}
