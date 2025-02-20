using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Startly.Domains;

namespace Startly.Configuration
{
        public class StartupAtuacaoConfigurantion : IEntityTypeConfiguration<StartupAtuacao>
        {
            public void Configure(EntityTypeBuilder<StartupAtuacao> builder)
            {

              builder.HasKey(a => a.Id);

              builder.Property(a => a.StartupId)
                .IsRequired();
                  
              builder.Property(a => a.AtuacaoId)
                .IsRequired();

              builder.ToTable("StartupAtuacao");

              builder.HasOne(a => a.Startup).WithMany(a => a.atuacaos).HasForeignKey(a => a.StartupId);
              builder.HasOne(a => a.Atuacao).WithMany(a => a.atuacaos).HasForeignKey(a => a.AtuacaoId);

            }
        }
}

