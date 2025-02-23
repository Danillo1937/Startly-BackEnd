namespace Startly.Domain
{
    public class StartupAtuacao
    {
        public Guid Id { get; set; }
        public Guid StartupId { get; set; }
        public Guid AtuacaoId{ get; set; }
        public required Startup Startup { get; set; }
        public required Atuacao Atuacao { get; set; }    
    }
}
