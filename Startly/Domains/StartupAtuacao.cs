
using Startly.Enumerators;

namespace Startly.Domains
{
    public class StartupAtuacao
    {
        public int Id { get; set; }
        public int StartupId { get; set; }
        public int AtuacaoId{ get; set; }
        public required Startup Startup { get; set; }
        public required Atuacao Atuacao { get; set; }    



    }
}
