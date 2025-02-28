using Startly.Enumerators;

namespace Startly.Domain.Entities
{
    public class Startup
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string metas { get; set; } = string.Empty;
        public string? CNPJ { get; set; }
        public string Cep { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public string UF { get; set; } = string.Empty;
        public string? SiteStartup { get; set; }
        public int QuantidadeFuncionario { get; set; }
        public EnumTicketMedio EnumTicket { get; set; }
        public string ResponsavelCadastro { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string ConfirmacaoSenha { get; set; } = string.Empty;
        public IEnumerable<StartupAtuacao> Atuacoes { get; set; } = [];
        public IEnumerable<StartupImagem> Imagens { get; set; } = [];
        public IEnumerable<StartupContato> Contatos { get; set; } = [];
        public IEnumerable<StartupVideo> Videos { get; set; } = [];
    }
}
