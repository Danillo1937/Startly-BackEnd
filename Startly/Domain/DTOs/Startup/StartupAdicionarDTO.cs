using Startly.Domain.Entities;
using Startly.Enumerators;

namespace Startly.Domain.DTOs.Startup
{
    public class StartupAdicionarDTO
    {
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


        public List<StartupAtuacaoAdicionarDTO> Atuacoes { get; set; } = [];
        public List<StartupVideoAdicionarDTO> Videos { get; set; } = []; 
        public List<StartupImagemAdicionarDTO> Imagens { get; set; } = [];
        public List<StartupContatoAdicionarDTO> Contatos { get; set; } = [];
        
    }
}
