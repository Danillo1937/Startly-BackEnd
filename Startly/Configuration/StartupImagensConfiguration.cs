
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Startly.Domains;

namespace Startly.Configuration
{
        public class StartupImagensConfigurantion : IEntityTypeConfiguration<StartupImagens>
        {
            public void Configure(EntityTypeBuilder<StartupImagens> builder)
            {
             builder.HasKey(i => i.Id);

             builder.Property(i => i.StartupId)
                .IsRequired();
 
             builder.Property(i => i.TipoImagem)
                .IsRequired();

             builder.Property(i => i.Imagem);

             builder.ToTable("StartupImagens");

             builder.HasOne(i => i.Startup).WithMany(i => i.imagens).HasForeignKey(i => i.StartupId);

            }
        }
    }

