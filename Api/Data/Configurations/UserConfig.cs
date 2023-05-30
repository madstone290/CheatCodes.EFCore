using Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Created);
            builder.Property(x => x.Type);
            builder.Property(x => x.Point);
            builder.HasMany(x => x.Bags).WithOne(b => b.Owner)
                .HasForeignKey(b => b.OwnerId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
