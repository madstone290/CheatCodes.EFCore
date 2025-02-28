using Api.Entities;
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
            builder.Property(x => x.Favorite);
            builder.Property(x => x.CarId);
            builder.Property(x => x.BikeId);

            builder.HasMany(x => x.Bags).WithOne(b => b.Owner)
                .HasForeignKey(b => b.OwnerId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Car).WithMany().HasForeignKey(x => x.CarId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Bike).WithMany().HasForeignKey(x => x.BikeId).OnDelete(DeleteBehavior.Restrict);


        }
    }
}
