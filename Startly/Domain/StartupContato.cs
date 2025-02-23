using Startly.Enumerators;

namespace Startly.Domain
{
    public class StartupContato
    {
        public Guid Id { get; set; }
        public Guid StartupId { get; set; }
        public EnumTipoContato Contato { get; set; }
        public string Conteudo { get; set; } = string.Empty;
        public required Startup Startup { get; set; }
    }
}
