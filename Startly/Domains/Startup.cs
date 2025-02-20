
using Startly.Enumerators;

namespace Startly.Domains
{
    public class Startup
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public List<StartupAtuacao> atuacaos { get; set; }
        public List<StartupImagens> imagens { get; set; }
        public List<StartupContato> contatos { get; set; }
        public List<StartupVideo> Videos { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string metas { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public string UF { get; set; } = string.Empty;
        public string SiteStartup { get; set; } = string.Empty;
        public int qtdeFuncionario { get; set; }
        public EnumTicket EnumTicket { get; set; }
        public string RespCadastro { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

    }
}
