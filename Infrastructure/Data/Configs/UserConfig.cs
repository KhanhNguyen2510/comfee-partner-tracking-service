using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configs
{
    public class UserConfig : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.CreatedUser).IsRequired(false);
            builder.Property(x => x.CreatedDate).HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.ModifyUser).IsRequired(false);
            builder.Property(x => x.ModifyDate).HasColumnType("smalldatetime").IsRequired(false);

            builder.Property(x => x.User).IsRequired();
            builder.Property(x => x.Lastname).IsRequired();
            builder.Property(x => x.FirstName).IsRequired();


            builder.Property(x => x.Phone).HasMaxLength(maxLength: 15).IsRequired(false);
            builder.Property(x => x.Email).HasMaxLength(maxLength: 20).IsRequired(false);
            builder.Property(x => x.Image).HasMaxLength(maxLength: 3000).IsRequired(false);
        }
    }
}