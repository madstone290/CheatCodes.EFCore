﻿// <auto-generated />
using System;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api.Data.Entities.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceiptDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Receipts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Item = "Pen",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Item = "Pen",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Item = "Pen",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Item = "Book",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Item = "Book",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Item = "Book",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Item = "Book",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Item = "Bottle",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            Item = "Bottle",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            Item = "Bottle",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            Item = "Bottle",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            Item = "Cup",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            Item = "Cup",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            Item = "Cup",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            Item = "Pen",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16,
                            Item = "Pen",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17,
                            Item = "Pen",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18,
                            Item = "Book",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 19,
                            Item = "Book",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 20,
                            Item = "Book",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 21,
                            Item = "Book",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 22,
                            Item = "Bottle",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 23,
                            Item = "Bottle",
                            Quantity = 10,
                            ReceiptDate = new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Api.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pen1",
                            Point = 10,
                            Type = "3rd"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pen2",
                            Point = 10,
                            Type = "Male"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pen3",
                            Point = 10,
                            Type = "3rd"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Book4",
                            Point = 10,
                            Type = "Male"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Book5",
                            Point = 10,
                            Type = "Female"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Book6",
                            Point = 10,
                            Type = "3rd"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Book7",
                            Point = 10,
                            Type = "3rd"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bottle1",
                            Point = 10,
                            Type = "Female"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bottle2",
                            Point = 10,
                            Type = "3rd"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bottle3",
                            Point = 10,
                            Type = "3rd"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bottle4",
                            Point = 10,
                            Type = "Female"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cup1",
                            Point = 10,
                            Type = "3rd"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cup2",
                            Point = 10,
                            Type = "Male"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cup3",
                            Point = 10,
                            Type = "3rd"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pen11",
                            Point = 10,
                            Type = "Female"
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pen12",
                            Point = 10,
                            Type = "Female"
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pen13",
                            Point = 10,
                            Type = "3rd"
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Book11",
                            Point = 10,
                            Type = "Male"
                        },
                        new
                        {
                            Id = 19,
                            Created = new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Book12",
                            Point = 10,
                            Type = "3rd"
                        },
                        new
                        {
                            Id = 20,
                            Created = new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Book13",
                            Point = 10,
                            Type = "Female"
                        },
                        new
                        {
                            Id = 21,
                            Created = new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Book14",
                            Point = 10,
                            Type = "Male"
                        },
                        new
                        {
                            Id = 22,
                            Created = new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bottle11",
                            Point = 10,
                            Type = "3rd"
                        },
                        new
                        {
                            Id = 23,
                            Created = new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bottle12",
                            Point = 10,
                            Type = "Female"
                        });
                });

            modelBuilder.Entity("Api.Data.Entities.UserBag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("UserBag");
                });

            modelBuilder.Entity("Api.Data.Entities.UserBag", b =>
                {
                    b.HasOne("Api.Data.Entities.User", "Owner")
                        .WithMany("Bags")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Api.Data.Entities.User", b =>
                {
                    b.Navigation("Bags");
                });
#pragma warning restore 612, 618
        }
    }
}
