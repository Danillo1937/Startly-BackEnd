namespace Startly.Domains
{
    public class Atuacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public List<StartupAtuacao> atuacaos { get; set; }  

    }
}
