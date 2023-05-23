using Microsoft.EntityFrameworkCore;
using Api.Data.Entities;

namespace Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Receipt> Receipts { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, Name = "Pen1", Point = 10, Created = new DateTime(2023, 1, 1) },
                new User() { Id = 2, Name = "Pen2", Point = 10, Created = new DateTime(2023, 1, 1) },
                new User() { Id = 3, Name = "Pen3", Point = 10, Created = new DateTime(2023, 2, 1) },
                new User() { Id = 4, Name = "Book4", Point = 10, Created = new DateTime(2023, 3, 1) },
                new User() { Id = 5, Name = "Book5", Point = 10, Created = new DateTime(2023, 4, 3) },
                new User() { Id = 6, Name = "Book6", Point = 10, Created = new DateTime(2023, 5, 3) },
                new User() { Id = 7, Name = "Book7", Point = 10, Created = new DateTime(2023, 6, 3) },
                new User() { Id = 8, Name = "Bottle1", Point = 10, Created = new DateTime(2023, 7, 3) },
                new User() { Id = 9, Name = "Bottle2", Point = 10, Created = new DateTime(2023, 7, 3) },
                new User() { Id = 10, Name = "Bottle3", Point = 10, Created = new DateTime(2023, 8, 3) },
                new User() { Id = 11, Name = "Bottle4", Point = 10, Created = new DateTime(2023, 9, 3) },
                new User() { Id = 12, Name = "Cup1", Point = 10, Created = new DateTime(2023, 9, 3) },
                new User() { Id = 13, Name = "Cup2", Point = 10, Created = new DateTime(2023, 9, 3) },
                new User() { Id = 14, Name = "Cup3", Point = 10, Created = new DateTime(2023, 10, 3) },
                new User() { Id = 15, Name = "Pen11", Point = 10, Created = new DateTime(2023, 5, 1) },
                new User() { Id = 16, Name = "Pen12", Point = 10, Created = new DateTime(2023, 6, 1) },
                new User() { Id = 17, Name = "Pen13", Point = 10, Created = new DateTime(2023, 7, 1) },
                new User() { Id = 18, Name = "Book11", Point = 10, Created = new DateTime(2023, 8, 1) },
                new User() { Id = 19, Name = "Book12", Point = 10, Created = new DateTime(2023, 9, 3) },
                new User() { Id = 20, Name = "Book13", Point = 10, Created = new DateTime(2023, 10, 3) },
                new User() { Id = 21, Name = "Book14", Point = 10, Created = new DateTime(2023, 6, 3) },
                new User() { Id = 22, Name = "Bottle11", Point = 10, Created = new DateTime(2023, 7, 3) },
                new User() { Id = 23, Name = "Bottle12", Point = 10, Created = new DateTime(2023, 7, 3) }
                );

            modelBuilder.Entity<Receipt>().HasData(
                new Receipt() { Id = 1, Item = "Pen", Quantity = 10, ReceiptDate = new DateTime(2023, 1, 1) },
                new Receipt() { Id = 2, Item = "Pen", Quantity = 10, ReceiptDate = new DateTime(2023, 1, 1) },
                new Receipt() { Id = 3, Item = "Pen", Quantity = 10, ReceiptDate = new DateTime(2023, 2, 1) },
                new Receipt() { Id = 4, Item = "Book", Quantity = 10, ReceiptDate = new DateTime(2023, 3, 1) },
                new Receipt() { Id = 5, Item = "Book", Quantity = 10, ReceiptDate = new DateTime(2023, 4, 3) },
                new Receipt() { Id = 6, Item = "Book", Quantity = 10, ReceiptDate = new DateTime(2023, 5, 3) },
                new Receipt() { Id = 7, Item = "Book", Quantity = 10, ReceiptDate = new DateTime(2023, 6, 3) },
                new Receipt() { Id = 8, Item = "Bottle", Quantity = 10, ReceiptDate = new DateTime(2023, 7, 3) },
                new Receipt() { Id = 9, Item = "Bottle", Quantity = 10, ReceiptDate = new DateTime(2023, 7, 3) },
                new Receipt() { Id = 10, Item = "Bottle", Quantity = 10, ReceiptDate = new DateTime(2023, 8, 3) },
                new Receipt() { Id = 11, Item = "Bottle", Quantity = 10, ReceiptDate = new DateTime(2023, 9, 3) },
                new Receipt() { Id = 12, Item = "Cup", Quantity = 10, ReceiptDate = new DateTime(2023, 9, 3) },
                new Receipt() { Id = 13, Item = "Cup", Quantity = 10, ReceiptDate = new DateTime(2023, 9, 3) },
                new Receipt() { Id = 14, Item = "Cup", Quantity = 10, ReceiptDate = new DateTime(2023, 10, 3) },
                new Receipt() { Id = 15, Item = "Pen", Quantity = 10, ReceiptDate = new DateTime(2023, 5, 1) },
                new Receipt() { Id = 16, Item = "Pen", Quantity = 10, ReceiptDate = new DateTime(2023, 6, 1) },
                new Receipt() { Id = 17, Item = "Pen", Quantity = 10, ReceiptDate = new DateTime(2023, 7, 1) },
                new Receipt() { Id = 18, Item = "Book", Quantity = 10, ReceiptDate = new DateTime(2023, 8, 1) },
                new Receipt() { Id = 19, Item = "Book", Quantity = 10, ReceiptDate = new DateTime(2023, 9, 3) },
                new Receipt() { Id = 20, Item = "Book", Quantity = 10, ReceiptDate = new DateTime(2023, 10, 3) },
                new Receipt() { Id = 21, Item = "Book", Quantity = 10, ReceiptDate = new DateTime(2023, 6, 3) },
                new Receipt() { Id = 22, Item = "Bottle", Quantity = 10, ReceiptDate = new DateTime(2023, 7, 3) },
                new Receipt() { Id = 23, Item = "Bottle", Quantity = 10, ReceiptDate = new DateTime(2023, 7, 3) }
            );
        }

    }
}

