﻿// <auto-generated />
using System;
using CustomerService.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CustomerService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CustomerService.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Address 1",
                            CreatedAt = new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9878),
                            Name = "Customer 1",
                            Phone = "05555555555",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Address = "Address 2",
                            CreatedAt = new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9906),
                            Name = "Customer 2",
                            Phone = "05555555555",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Address = "Address 3",
                            CreatedAt = new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9908),
                            Name = "Customer 3",
                            Phone = "05555555555",
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Address = "Address 4",
                            CreatedAt = new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9909),
                            Name = "Customer 4",
                            Phone = "05555555555",
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            Address = "Address 5",
                            CreatedAt = new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9911),
                            Name = "Customer 5",
                            Phone = "05555555555",
                            Status = true
                        },
                        new
                        {
                            Id = 6,
                            Address = "Address 6",
                            CreatedAt = new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9913),
                            Name = "Customer 6",
                            Phone = "05555555555",
                            Status = true
                        },
                        new
                        {
                            Id = 7,
                            Address = "Address 7",
                            CreatedAt = new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9915),
                            Name = "Customer 7",
                            Phone = "05555555555",
                            Status = true
                        },
                        new
                        {
                            Id = 8,
                            Address = "Address 8",
                            CreatedAt = new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9916),
                            Name = "Customer 8",
                            Phone = "05555555555",
                            Status = true
                        },
                        new
                        {
                            Id = 9,
                            Address = "Address 9",
                            CreatedAt = new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9917),
                            Name = "Customer 9",
                            Phone = "05555555555",
                            Status = true
                        },
                        new
                        {
                            Id = 10,
                            Address = "Address 10",
                            CreatedAt = new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9919),
                            Name = "Customer 10",
                            Phone = "05555555555",
                            Status = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
