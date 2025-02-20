using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Startly.Domains;

namespace Startly.Configuration
{
        public class StartupContatoConfigurantion : IEntityTypeConfiguration<StartupContato>
        {
            public void Configure(EntityTypeBuilder<StartupContato> builder)
            {
               builder.HasKey(t => t.Id);

               builder.Property(t => t.StartupId)
                .IsRequired();

               builder.Property(t => t.Conteudo)
                 .IsRequired()
                 .HasMaxLength(300);

                builder.Property(t => t.Contato)
                 .IsRequired();

                builder.ToTable("StartupContato");

                builder.HasOne(t => t.Startup).WithMany(t => t.contatos).HasForeignKey(t => t.StartupId);

            }
        }
}

