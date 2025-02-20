using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Startly.Domains;

namespace Startly.Configuration
{
    public class StartupConfiguration : IEntityTypeConfiguration<Startup>
    {
        public void Configure(EntityTypeBuilder<Startup> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(p => p.metas)
                .IsRequired()
                .HasMaxLength (3000);
                
            builder.Property(p => p.CNPJ)
                .HasMaxLength(14);

            builder.Property(p => p.Cep)
                .IsRequired()
                .HasMaxLength (9);

            builder.Property(p => p.Logradouro)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Numero)
                .IsRequired()
                .HasMaxLength(5);

            builder.Property(p => p.Bairro)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Municipio)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.UF)
                .IsRequired()
                .HasMaxLength(2);

            builder.Property(p => p.SiteStartup)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(p => p.qtdeFuncionario)
                .IsRequired();

            builder.Property(p => p.EnumTicket)
                 .HasConversion<string>()
                 .IsRequired();

            builder.Property(p => p.RespCadastro)
                 .IsRequired()
                 .HasMaxLength(100);

            builder.Property(p => p.Login)
                 .IsRequired()
                 .HasMaxLength(30);

            builder.Property(p => p.Senha)
                 .IsRequired();

            builder.ToTable("Startup");

        }
    }
}
