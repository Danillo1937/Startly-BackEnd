using Startly.Enumerators;

namespace Startly.Domains
{
    public class StartupContato
    {
        public int Id { get; set; }
        public int StartupId { get; set; }
        public string Conteudo { get; set; } = string.Empty;
        public  Startup Startup { get; set; }
        public EnumContato Contato { get; set; }
    }
}
