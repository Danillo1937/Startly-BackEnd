using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Startly.Domains;

namespace Startly.Configuration
{
    public class StartupVideoConfiguration : IEntityTypeConfiguration<StartupVideo>
    {
        public void Configure(EntityTypeBuilder<StartupVideo> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.LinkVideo)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(v => v.StartupId)
                .IsRequired();

            builder.HasOne(v => v.Startup).WithMany(v => v.Videos).HasForeignKey(v => v.StartupId);

            builder.ToTable("StartupVideo");
        }
    }
}
