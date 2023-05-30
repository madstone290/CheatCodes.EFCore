using Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Configurations
{
    public class UserBagConfig : IEntityTypeConfiguration<UserBag>
    {
        public void Configure(EntityTypeBuilder<UserBag> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Capacity);
            builder.HasOne(x => x.Owner).WithMany(u => u.Bags)
                .HasForeignKey(b => b.OwnerId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
