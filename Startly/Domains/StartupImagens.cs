using Startly.Enumerators;

namespace Startly.Domains
{
    public class StartupImagens
    {
        public int Id { get; set; }
        public int StartupId { get; set; }
        public EnumTipoImagem TipoImagem { get; set; }
        public string Imagem { get; set; } = string.Empty;
        public Startup Startup { get; set; }

    }
}
