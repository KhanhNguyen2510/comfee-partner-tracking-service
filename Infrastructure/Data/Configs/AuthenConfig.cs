using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configs
{
    public class AuthenConfig : IEntityTypeConfiguration<AuthenEntity>
    {
        public void Configure(EntityTypeBuilder<AuthenEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.CreatedUser).IsRequired(false);
            builder.Property(x => x.CreatedDate).HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.ModifyUser).IsRequired(false);
            builder.Property(x => x.ModifyDate).HasColumnType("smalldatetime").IsRequired(false);

            builder.Property(x => x.User).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Token).IsRequired(false);
            builder.Property(x => x.RefeshToken).IsRequired(false);
            builder.Property(x => x.IsLogin).HasDefaultValue(false).IsRequired();
            builder.Property(x => x.SaltToken).HasDefaultValue("salt-pts").IsRequired(false);
        }
    }
}