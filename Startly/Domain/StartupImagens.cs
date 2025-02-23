using Startly.Enumerators;

namespace Startly.Domain
{
    public class StartupImagem
    {
        public Guid Id { get; set; }
        public Guid StartupId { get; set; }
        public EnumTipoImagem TipoImagem { get; set; }
        public string Imagem { get; set; } = string.Empty;
        public required Startup Startup { get; set; }
    }
}
